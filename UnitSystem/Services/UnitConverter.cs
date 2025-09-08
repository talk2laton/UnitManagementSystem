using System;
using UnitSystem.Models;
using UnitSystem.Parsing;
using UnitSystem.Registry;

namespace UnitSystem.Services
{
    public static class UnitConverter
    {
        static UnitExpressionParser parser = new(UnitRegistry.Units, UnitRegistry.Prefixes);
        public static double Convert(double value, Unit from, Unit to)
        {
            if (!from.Dimensions.Equals(to.Dimensions))
                throw new InvalidOperationException("Incompatible units");

            double baseValue = value * from.ConversionFactorToBase;
            return baseValue / to.ConversionFactorToBase;
        }

        public static double Convert(double value, string from, string to)
        {
            return Convert(value, parser.Parse(from), parser.Parse(to));
        }
    }
}
