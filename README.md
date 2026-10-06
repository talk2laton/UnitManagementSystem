# UnitConverter

A versatile, high-precision .NET unit conversion library capable of parsing and converting standard physical units, complex derived expressions, SI prefixes, and dimensional powers across engineering, scientific, and esoteric domains.

---

## Features

- **Compound Expressions & Dimensional Algebra:** Supports multiplication (`*`), division (`/`), and powers (`^2`, `^3`).
- **Domain Coverage:** Handles everyday units, engineering/petroleum standards (Darcy, barrels, acre-feet), electronics, astrophysics (astronomical units, parsecs), and historical/FFF systems.
- **Prefix & Symbol Support:** Metric prefixes (kilo, milli, micro `µ`) alongside standard scientific symbols (`Ω`, `Å`, `°R`).
- **Minimal API:** One simple call handles parsing, dimension validation, and numerical conversion.

---

## Installation

Install via the .NET CLI:

```bash
dotnet add package UnitSystem
```

Or via the NuGet Package Manager Console:

```powershell
Install-Package UnitSystem
```

---

## Quick Start

Import the namespace and invoke `UnitConverter.Convert`:

```csharp
using UnitSystem.Services;

// Simple conversions
double metersPerSecond = 25.0;
double kmh = UnitConverter.Convert(metersPerSecond, "m/s", "km/hr");
double mph = UnitConverter.Convert(metersPerSecond, "m/s", "mi/hr");

// Area & Volume
double sqFeet = UnitConverter.Convert(5.0, "ac", "ft^2");
double liters = UnitConverter.Convert(1.0, "bbl", "ltr");
double cubicMeters = UnitConverter.Convert(2.5, "ac*ft", "m^3");

// Electrical & Energy
double coulombs = UnitConverter.Convert(7000, "mA*hr", "C");
double resistance = UnitConverter.Convert(12.0, "V^2/W", "kΩ");
double work = UnitConverter.Convert(100.0, "J", "N*m");
```

---

## Usage Examples

### 1. Gas Constants & Thermodynamic Quantities
Convert compound, multi-term thermal quantities and universal gas constants across engineering frameworks:

```csharp
double rSI = 8.31446261815324; // J/(mol·K)

// Standard engineering and chemistry formats
double rAtm  = UnitConverter.Convert(rSI, "J/mol/K", "ltr*atm/mol/K");
double rPsi  = UnitConverter.Convert(rSI, "J/mol/K", "psi*ft^3/lbmol/°R");
double rBtu  = UnitConverter.Convert(rSI, "J/mol/K", "btu/lbmol/°R");
double rTorr = UnitConverter.Convert(rSI, "J/mol/K", "torr*m^3/lbmol/K");
double rCal  = UnitConverter.Convert(rSI, "J/mol/K", "cal/mol/K");
double rWs   = UnitConverter.Convert(rSI, "J/mol/K", "W*s/mol/°R");
double rBar  = UnitConverter.Convert(rSI, "J/mol/K", "ltr*bar/mol/°R");
double rHg   = UnitConverter.Convert(rSI, "J/mol/K", "mmHg*gal/lbmol/°R");
```

### 2. Density & Petroleum Engineering
Handles industry-standard metrics like Darcy permeability, oilfield barrels (`bbl`, `Mbbl`, `MMbbl`), and mass densities:

```csharp
// Permeability
double permeability = UnitConverter.Convert(0.15, "Darcy", "m^2");

// Volume & Acre-feet conversions
double m3    = UnitConverter.Convert(10.0, "ac*ft", "m^3");
double mbbl  = UnitConverter.Convert(10.0, "ac*ft", "Mbbl");
double mmbbl = UnitConverter.Convert(10.0, "ac*ft", "MMbbl");

// Fluid density
double waterDensity = 1000.0; // kg/m^3
double lbBbl = UnitConverter.Convert(waterDensity, "kg/m^3", "lb/bbl");
double lbFt3 = UnitConverter.Convert(waterDensity, "kg/m^3", "lb/ft^3");
double gCm3  = UnitConverter.Convert(waterDensity, "kg/m^3", "g/cm^3");
double gLtr  = UnitConverter.Convert(waterDensity, "kg/m^3", "g/ltr");
double ozBbl = UnitConverter.Convert(waterDensity, "kg/m^3", "oz/bbl");
```

### 3. High-Velocity & Astronomical Distances
Convert atomic and astronomical scales seamlessly:

```csharp
// Speed of light to astronomical units per minute
double c = 3e8; // m/s
double speedAuMin = UnitConverter.Convert(c, "m/s", "AU/min");

// Atomic displacement velocities
double atomicSpeed = UnitConverter.Convert(1000.0, "Å/s", "kn");

// Cosmological densities
double galacticDensity = UnitConverter.Convert(1000.0, "kg/m^3", "g/pc^3");
```

### 4. Esoteric & FFF Units
Supports unconventional units for specialized calculations or playful conversions:

```csharp
double energyRate = UnitConverter.Convert(1.0, "firkin*atm/µfortnight", "erg/jiffy");
```

---

## Expression Syntax Rules

| Operation | Operator | Examples |
| :--- | :---: | :--- |
| **Multiplication** | `*` | `N*m`, `mA*hr`, `ac*ft`, `ltr*atm` |
| **Division** | `/` | `m/s`, `J/mol/K`, `kg/m^3`, `V^2/W` |
| **Exponentiation** | `^` | `ft^2`, `m^3`, `pc^3`, `V^2` |
| **Unicode Symbols** | Exact chars | `µ` (micro), `Ω` (ohm), `Å` (angstrom), `°R` (Rankine) |

---

## Error Handling

If the source and target unit expressions do not resolve to the same underlying physical dimensions (for example, attempting to convert length into power), `UnitConverter.Convert` throws an exception indicating the dimensional mismatch.

```csharp
try
{
    // Throws an exception: Cannot convert mass to velocity
    double invalid = UnitConverter.Convert(10.0, "kg", "m/s");
}
catch (ArgumentException ex)
{
    Console.WriteLine($"Conversion failed: {ex.Message}");
}
```

---

## License

This project is licensed under the [MIT License](LICENSE).
