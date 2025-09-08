namespace UnitSystem.Models
{
    public class Unit(string name, string symbol, DimensionVector dimensions, double factor)
    {
        public string Name { get; } = name;
        public string Symbol { get; } = symbol;
        public DimensionVector Dimensions { get; } = dimensions;
        public double ConversionFactorToBase { get; } = factor;
    }

}
