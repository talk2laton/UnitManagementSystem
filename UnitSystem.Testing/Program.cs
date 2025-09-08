using UnitSystem.Parsing;
using UnitSystem.Registry;
using UnitSystem.Services;

var parser = new UnitExpressionParser(UnitRegistry.Units, UnitRegistry.Prefixes);


var Random = new Random(); double rand;
Console.WriteLine($"{rand = Random.NextDouble()} J is {UnitConverter.Convert(rand, "J", "N*m")} N*m");
Console.WriteLine($"{rand = Random.NextDouble()} acres is {UnitConverter.Convert(rand, "ac", "ft^2")} ft^2");
Console.WriteLine($"{rand = 7000} mAhr is {UnitConverter.Convert(rand, "mA*hr", "C")} Coulombs");
Console.WriteLine($"{rand = Random.NextDouble()} V^2/W is {UnitConverter.Convert(rand, "V^2/W", "kΩ")} kΩ");
Console.WriteLine($"{rand = Random.NextDouble()} Darcy is {UnitConverter.Convert(rand, "Darcy", "m^2")} m^2");
Console.WriteLine($"{rand = Random.NextDouble()} m/s is {UnitConverter.Convert(rand, "m/s", "km/hr")} km/hr");
Console.WriteLine($"{rand = Random.NextDouble()} m/s is {UnitConverter.Convert(rand, "m/s", "ft/s")} ft/s");
Console.WriteLine($"{rand = Random.NextDouble()} m/s is {UnitConverter.Convert(rand, "m/s", "mi/hr")} mi/hr");
Console.WriteLine($"{rand = Random.NextDouble()} Å/s is {UnitConverter.Convert(rand, "Å/s", "kn")} kn");
Console.WriteLine($"{rand = Random.NextDouble()} m/s is {UnitConverter.Convert(rand, "m/s", "kn")} kn");
Console.WriteLine($"{rand = Random.NextDouble()} ac*ft is {UnitConverter.Convert(rand, "ac*ft", "m^3")} m^3");
Console.WriteLine($"{rand = Random.NextDouble()} ac*ft is {UnitConverter.Convert(rand, "ac*ft", "Mbbl")} Mbbl");
Console.WriteLine($"{rand = Random.NextDouble()} ac*ft is {UnitConverter.Convert(rand, "ac*ft", "MMbbl")} MMbbl");
Console.WriteLine($"{rand = 1000} kg/m^3 is {UnitConverter.Convert(rand, "kg/m^3", "lb/bbl")} lb/bbl");
Console.WriteLine($"{rand = 1000} kg/m^3 is {UnitConverter.Convert(rand, "kg/m^3", "lb/ft^3")} lb/ft^3");
Console.WriteLine($"{rand = 1000} kg/m^3 is {UnitConverter.Convert(rand, "kg/m^3", "g/cm^3")} g/cm^3");
Console.WriteLine($"{rand = 1000} kg/m^3 is {UnitConverter.Convert(rand, "kg/m^3", "g/ltr")} g/ltr");
Console.WriteLine($"{rand = 1000} kg/m^3 is {UnitConverter.Convert(rand, "kg/m^3", "oz/bbl")} oz/bbl");
Console.WriteLine($"{rand = 1} bbl is {UnitConverter.Convert(rand, "bbl", "ltr")} ltr");
Console.WriteLine($"{rand = 8.31446261815324} J/mol/K is {UnitConverter.Convert(rand, "J/mol/K", "ltr*atm/mol/K")} ltr*atm/mol/K");
Console.WriteLine($"{rand = 8.31446261815324} J/mol/K is {UnitConverter.Convert(rand, "J/mol/K", "psi*ft^3/lbmol/°R")} psi*ft^3/lbmol/°R");
Console.WriteLine($"{rand = 8.31446261815324} J/mol/K is {UnitConverter.Convert(rand, "J/mol/K", "atm*ft^3/lbmol/°R")} atm*ft^3/lbmol/°R");
Console.WriteLine($"{rand = 8.31446261815324} J/mol/K is {UnitConverter.Convert(rand, "J/mol/K", "torr*m^3/lbmol/K")} torr*m^3/lbmol/K");
Console.WriteLine($"{rand = 8.31446261815324} J/mol/K is {UnitConverter.Convert(rand, "J/mol/K", "cal/mol/K)")} cal/mol/K");
Console.WriteLine($"{rand = 8.31446261815324} J/mol/K is {UnitConverter.Convert(rand, "J/mol/K", "btu/lbmol/°R")} btu/lbmol/°R");
Console.WriteLine($"{rand = 8.31446261815324} J/mol/K is {UnitConverter.Convert(rand, "J/mol/K", "W*s/mol/°R")} W*s/mol/°R");
Console.WriteLine($"{rand = 8.31446261815324} J/mol/K is {UnitConverter.Convert(rand, "J/mol/K", "ltr*bar/mol/°R")} ltr*bar/mol/°R");
Console.WriteLine($"{rand = 8.31446261815324} J/mol/K is {UnitConverter.Convert(rand, "J/mol/K", "mmHg*gal/lbmol/°R")} mmHg*gal/lbmol/°R");
Console.WriteLine($"{rand = 1000} kg/m^3 is {UnitConverter.Convert(rand, "kg/m^3", "g/pc^3")} pc^3");
Console.WriteLine($"{rand = 3e8} m/s is {UnitConverter.Convert(rand, "m/s", "AU/min")}  AU/min");
