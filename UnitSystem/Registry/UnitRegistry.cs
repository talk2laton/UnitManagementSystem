

using System.Collections.Generic;
using UnitSystem.Models;

namespace UnitSystem.Registry
{
    public static class UnitRegistry
    {
        public static Dictionary<string, Unit> Units = new()
        {
            //Time Section
            ["jiffy"] = new("jiffy", "jiffy", new DimensionVector { Time = 1 }, 3.33564095198e-11),
            ["s"]   = new("second", "s", new DimensionVector { Time = 1 }, 1.0),
            ["min"] = new("minute", "min", new DimensionVector { Time = 1 }, 60.0),
            ["hr"]  = new("hour", "hr", new DimensionVector { Time = 1 }, 3600.0),
            ["d"]   = new("day", "d", new DimensionVector { Time = 1 }, 86400.0),
            ["wk"]  = new("week", "wk", new DimensionVector { Time = 1 }, 604800.0),
            ["fortnight"] = new("fortnight", "fortnight", new DimensionVector { Time = 1 }, 1209600.0),
            ["yr"]  = new("year", "yr", new DimensionVector { Time = 1 }, 31536000.0),

            // Length Section
            ["m"]  = new("meter", "m", new DimensionVector { Length = 1 }, 1.0),
            ["ft"] = new("foot", "ft", new DimensionVector { Length = 1 }, 0.3048),
            ["in"] = new("inch", "in", new DimensionVector { Length = 1 }, 0.0254),
            ["mi"] = new("mile", "mi", new DimensionVector { Length = 1 }, 1609.344),
            ["yd"] = new("yard", "yd", new DimensionVector { Length = 1 }, 0.9144),
            ["Å"]  = new("angstrom", "Å", new DimensionVector { Length = 1 }, 1e-10),
            ["AU"]  = new("astronomical unit", "AU", new DimensionVector { Length = 1 }, 1.495978707e11),
            ["pc"]  = new("1 AU parallex arcsec", "pc", new DimensionVector { Length = 1 }, 3.08567758128e16),

            // Mass Section
            ["kg"]  = new("kilogram", "kg", new DimensionVector { Mass = 1 }, 1.0),
            ["lb"]  = new("pound", "lb", new DimensionVector { Mass = 1 }, 0.45359237),
            ["oz"]  = new("ounce", "oz", new DimensionVector { Mass = 1 }, 0.02834952),
            ["ton"] = new("tonne", "ton", new DimensionVector { Mass = 1 }, 1000.0),
            ["g"]   = new("gram", "g", new DimensionVector { Mass = 1 }, 0.001),

            // Temperature Section
            ["K"]   = new("kelvin", "K", new DimensionVector { Temperature = 1 }, 1.0),
            ["°C"]  = new("celsius", "°C", new DimensionVector { Temperature = 1 }, 1.0),
            ["°F"]  = new("fahrenheit", "°F", new DimensionVector { Temperature = 1 }, 5.0 / 9.0),
            ["°R"]  = new("rankine", "°R", new DimensionVector { Temperature = 1 }, 5.0 / 9.0),
            ["°De"] = new("delisle", "°De", new DimensionVector { Temperature = 1 }, -2.0 / 3.0),

            // Electic Current Section
            ["A"] = new("ampere", "A", new DimensionVector { ElectricCurrent = 1 }, 1.0),

            // Quantity of Eletricity Section
            ["C"] = new("coulomb", "C", new DimensionVector { ElectricCurrent = 1, Time = 1 }, 1.0),

            // Quantity of Substance Section
            ["mol"] = new("mole", "mol", new DimensionVector { AmountOfSubstance = 1 }, 1.0),
            ["lbmol"] = new("pound_mole", "lbmol", new DimensionVector { AmountOfSubstance = 1 }, 453.59237),

            // Luminous Intensity Section
            ["cd"] = new("candela", "cd", new DimensionVector { LuminousIntensity = 1 }, 1.0),

            // Area Section
            ["m²"]    = new("square meter", "m^2", new DimensionVector { Length = 2 }, 1.0),
            ["ha"]    = new("hectare", "ha", new DimensionVector { Length = 2 }, 10000.0),
            ["ac"]    = new("acre", "ac", new DimensionVector { Length = 2 }, 4.0468564224e3),
            ["Darcy"] = new Unit("Darcy", "Darcy", new DimensionVector { Length = 2 }, 9.869233e-13),

            // Volume Section
            ["m³"]    = new("cubic meter", "m^3", new DimensionVector { Length = 3 }, 1.0),
            ["ltr"]   = new("liter", "ltr", new DimensionVector { Length = 3 }, 0.001),
            ["gal"] = new("gallon", "gal", new DimensionVector { Length = 3 }, 0.003785411784),
            ["firkin"] = new("firkin", "firkin", new DimensionVector { Length = 3 }, 0.034068706056),
            ["pt"]    = new("pint", "pt", new DimensionVector { Length = 3 }, 0.000473176473),
            ["qt"]    = new("quart", "qt", new DimensionVector { Length = 3 }, 0.000946352946),
            ["bbl"]   = new("barrel", "bbl", new DimensionVector { Length = 3 }, 0.158987294928),
            ["STB"]   = new("standard barrel", "STB", new DimensionVector { Length = 3 }, 0.158987294928),
            ["scf"]   = new("standard cubic feet", "scf", new DimensionVector { Length = 3 }, 0.028316846592),
            ["MMbbl"] = new("million barrel", "MMbbl", new DimensionVector { Length = 3 }, 1.58987294928e5),
            ["Bbbl"]  = new("billion barrel", "Bbbl", new DimensionVector { Length = 3 }, 1.58987294928e8),
            ["MMSTB"] = new("million standard barrel", "MMSTB", new DimensionVector { Length = 3 }, 1.58987294928e5),
            ["BSTB"]  = new("billion standard barrel", "BSTB", new DimensionVector { Length = 3 }, 1.58987294928e8),
            ["MMscf"] = new("million standard cubic feet", "MMscf", new DimensionVector { Length = 3 }, 2.8316846592e4),
            ["Bscf"]  = new("billion standard cubic feet", "Bscf", new DimensionVector { Length = 3 }, 2.8316846592e7),

            // Watt Section
            ["W"] = new("watt", "W", new DimensionVector { Mass = 1, Length = 2, Time = -3 }, 1.0),

            // Force Section
            ["N"]   = new("newton", "N", new DimensionVector { Mass = 1, Length = 1, Time = -2 }, 1.0),
            ["lbf"] = new("pound-force", "lbf", new DimensionVector { Mass = 1, Length = 1, Time = -2 }, 4.4482216152605),
            ["dyn"] = new("dyne", "dyn", new DimensionVector { Mass = 1, Length = 1, Time = -2 }, 1e-5),

            // Pressure Section
            ["Pa"]   = new("pascal", "Pa", new DimensionVector { Mass = 1, Length = -1, Time = -2 }, 1.0),
            ["bar"]  = new("bar", "bar", new DimensionVector { Mass = 1, Length = -1, Time = -2 }, 1e5),
            ["atm"]  = new("atmosphere", "atm", new DimensionVector { Mass = 1, Length = -1, Time = -2 }, 1.01325e5),
            ["torr"] = new("torr", "torr", new DimensionVector { Mass = 1, Length = -1, Time = -2 }, 1.33322368421e2),
            ["mmHg"] = new("millimeter of mercury", "mmHg", new DimensionVector { Mass = 1, Length = -1, Time = -2 }, 1.33322368421e2),
            ["psi"]  = new("pound per square inch", "psi", new DimensionVector { Mass = 1, Length = -1, Time = -2 }, 6.894757293168361e3),

            // Velocity Section
            ["kn"]   = new("knot", "kn", new DimensionVector { Length = 1, Time = -1 }, 0.5144444444444445),

            // Energy Section
            ["J"] = new("joule", "J", new DimensionVector { Mass = 1, Length = 2, Time = -2 }, 1.0),
            ["erg"] = new("erg", "erg", new DimensionVector { Mass = 1, Length = 2, Time = -2 }, 1.0e-7),
            ["cal"] = new("calorie", "cal", new DimensionVector { Mass = 1, Length = 2, Time = -2 }, 4.184),
            ["btu"] = new("british thermal unit", "btu", new DimensionVector { Mass = 1, Length = 2, Time = -2 }, 1055.06),


            // Electric Current Section
            ["A"] = new("ampere", "A", new DimensionVector { ElectricCurrent = 1 }, 1.0),

            // Electric Potential Section
            ["V"] = new("volt", "V", new DimensionVector { Mass = 1, Length = 2, Time = -3, ElectricCurrent = -1 }, 1.0),

            // Electric Resistance Section
            ["Ω"] = new("ohm", "Ω", new DimensionVector { Mass = 1, Length = 2, Time = -3, ElectricCurrent = -2 }, 1.0),

            // Capacitance Section
            ["F"] = new("farad", "F", new DimensionVector { Mass = -1, Length = -2, Time = 4, ElectricCurrent = 2 }, 1.0),

            // Inductance Section
            ["H"] = new("henry", "H", new DimensionVector { Mass = 1, Length = 2, Time = -2, ElectricCurrent = -2 }, 1.0),
        };

        public static Dictionary<string, Prefix> Prefixes = new()
        {
            ["y"]   = new Prefix("yocto", "y", 1e-24),
            ["z"]   = new Prefix("zepto", "z", 1e-21),
            ["a"]   = new Prefix("atto", "a", 1e-18),
            ["f"]   = new Prefix("femto", "f", 1e-15),
            ["p"]   = new Prefix("pico", "p", 1e-12),
            ["n"]   = new Prefix("nano", "n", 1e-9),
            ["µ"]   = new Prefix("micro", "µ", 1e-6),
            ["m"]   = new Prefix("milli", "m", 1e-3),
            ["c"]   = new Prefix("centi", "c", 1e-2),
            ["d"]   = new Prefix("deci", "d", 1e-1),
            ["da"]  = new Prefix("deca", "da", 1e1),
            ["h"]   = new Prefix("hecto", "h", 1e2),
            ["k"]   = new Prefix("kilo", "k", 1e3),
            ["M"]   = new Prefix("Mega", "M", 1e6),
            ["G"]   = new Prefix("Giga", "G", 1e9),
            ["T"]   = new Prefix("Tera", "T", 1e12),
            ["P"]   = new Prefix("Peta", "P", 1e15),
            ["E"]   = new Prefix("Exa", "E", 1e18),
            ["Z"]   = new Prefix("zetta", "Z", 1e21),
            ["Y"]   = new Prefix("yotta", "Y", 1e24),
        };
    }
}
