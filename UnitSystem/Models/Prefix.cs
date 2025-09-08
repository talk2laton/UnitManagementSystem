namespace UnitSystem.Models
{
    public class Prefix(string name, string symbol, double factor)
    {
        public string Name { get; } = name;
        public string Symbol { get; } = symbol;
        public double Factor { get; } = factor;
    }

}
