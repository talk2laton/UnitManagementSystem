using System;
using System.Linq;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using UnitSystem.Models;

namespace UnitSystem.Parsing
{
    public class UnitExpressionParser(Dictionary<string, Unit> units, Dictionary<string, Prefix> prefixes)
    {
        private readonly Dictionary<string, Unit> units = units;
        private readonly Dictionary<string, Prefix> prefixes = prefixes;
        private readonly HashSet<string> fieldSymbols = ["bbl", "scf", "STB"];

        public Unit Parse(string expression)
        {
            var tokens = Tokenize(expression);
            var stack = new Stack<Unit>();
            var ops = new Stack<string>();

            foreach (var token in tokens)
            {
                if (token == "*" || token == "/")
                {
                    ops.Push(token);
                }
                else
                {
                    var unit = ParseSingleUnit(token);
                    if (stack.Count == 0)
                    {
                        stack.Push(unit);
                    }
                    else
                    {
                        var op = ops.Pop();
                        var left = stack.Pop();
                        var result = CombineUnits(left, unit, op);
                        stack.Push(result);
                    }
                }
            }

            return stack.Pop();
        }

        private List<string> Tokenize(string expr)
        {
            return [..Regex.Matches(expr, @"[a-zA-ZµΩÅ°]+(?:\^?\d+)?|\*|/").Cast<Match>().Select(m => m.Value)];
        }

        private Unit ParseSingleUnit(string token)
        {
            var match = Regex.Match(token, @"^([a-zA-ZµΩÅ°]+)(\^?\d+)?$");
            if (!match.Success) throw new ArgumentException($"Invalid token: {token}");

            string symbol = match.Groups[1].Value;
            int exponent = 1;
            if (match.Groups[2].Success)
            {
                var expStr = match.Groups[2].Value.Replace("^", "");
                exponent = int.Parse(expStr);
            }

            var unit = TryParsePrefixedUnit(symbol);
            return new Unit(
                unit.Name,
                unit.Symbol,
                unit.Dimensions.Pow(exponent),
                Math.Pow(unit.ConversionFactorToBase, exponent)
            );
        }

        private Unit TryParsePrefixedUnit(string symbol)
        {
            if (units.TryGetValue(symbol, out var unit))
                return unit;

            foreach (var prefix in prefixes.Values.OrderByDescending(p => p.Symbol.Length))
            {
                if (symbol.StartsWith(prefix.Symbol))
                {
                    var baseSymbol = symbol.Substring(prefix.Symbol.Length);
                    if (units.TryGetValue(baseSymbol, out var baseUnit))
                    {
                        if (prefix.Symbol == "M" && fieldSymbols.Contains(baseUnit.Symbol))
                        {
                            return new Unit(
                                prefix.Name + baseUnit.Name,
                                prefix.Symbol + baseUnit.Symbol,
                                baseUnit.Dimensions,
                                baseUnit.ConversionFactorToBase * 1e3
                            );
                        }
                        return new Unit(
                            prefix.Name + baseUnit.Name,
                            prefix.Symbol + baseUnit.Symbol,
                            baseUnit.Dimensions,
                            baseUnit.ConversionFactorToBase * prefix.Factor
                        );
                    }
                }
            }

            throw new ArgumentException($"Unknown unit: {symbol}");
        }

        private Unit CombineUnits(Unit a, Unit b, string op)
        {
            return new Unit(
                $"{a.Name} {op} {b.Name}",
                $"{a.Symbol}{op}{b.Symbol}",
                op == "*" ? a.Dimensions + b.Dimensions : a.Dimensions - b.Dimensions,
                op == "*" ? a.ConversionFactorToBase * b.ConversionFactorToBase : a.ConversionFactorToBase / b.ConversionFactorToBase
            );
        }
    }
}
