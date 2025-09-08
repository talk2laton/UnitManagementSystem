namespace UnitSystem.Models
{
    public record DimensionVector
    {
        public int Length { get; set; }
        public int Mass { get; set; }
        public int Time { get; set; }
        public int Temperature { get; set; }
        public int ElectricCurrent { get; set; }
        public int AmountOfSubstance { get; set; }
        public int LuminousIntensity { get; set; }

        public static DimensionVector operator +(DimensionVector a, DimensionVector b) => new DimensionVector
        {
            Length = a.Length + b.Length,
            Mass = a.Mass + b.Mass,
            Time = a.Time + b.Time,
            Temperature = a.Temperature + b.Temperature,
            ElectricCurrent = a.ElectricCurrent + b.ElectricCurrent,
            AmountOfSubstance = a.AmountOfSubstance + b.AmountOfSubstance,
            LuminousIntensity = a.LuminousIntensity + b.LuminousIntensity
        };

        public static DimensionVector operator -(DimensionVector a, DimensionVector b) => new DimensionVector
        {
            Length = a.Length - b.Length,
            Mass = a.Mass - b.Mass,
            Time = a.Time - b.Time,
            Temperature = a.Temperature - b.Temperature,
            ElectricCurrent = a.ElectricCurrent - b.ElectricCurrent,
            AmountOfSubstance = a.AmountOfSubstance - b.AmountOfSubstance,
            LuminousIntensity = a.LuminousIntensity - b.LuminousIntensity
        };

        public DimensionVector Pow(int exponent) => new DimensionVector
        {
            Length = Length * exponent,
            Mass = Mass * exponent,
            Time = Time * exponent,
            Temperature = Temperature * exponent,
            ElectricCurrent = ElectricCurrent * exponent,
            AmountOfSubstance = AmountOfSubstance * exponent,
            LuminousIntensity = LuminousIntensity * exponent
        };
    }
}
