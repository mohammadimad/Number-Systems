**English** | [العربية](README.ar.md)

# Number Systems Converter

A Windows Forms desktop application for converting values between decimal, binary, octal, and hexadecimal number systems. The project focuses on base conversion, input checking, form events, and interactive desktop UI controls.

## Features

- Select a source and target number system.
- Convert between decimal, binary, octal, and hexadecimal representations.
- Swap the selected source and target systems.
- Reset the input and result fields.
- Validate binary and octal digits before conversion.
- Display the selected systems and conversion result in the interface.
- Close the application through a dedicated control.

## Tech Stack

- C#
- Windows Forms
- .NET Framework 4.7.2

## Project Structure

```text
Counting systems/
|-- Counting systems.sln
|-- Counting systems.csproj
|-- Program.cs             # Application entry point
|-- Form1.cs               # Conversion and UI event logic
|-- Form1.Designer.cs      # Form layout and controls
`-- Properties/            # Resources, settings, and assembly metadata
```

## Build and Run

### Prerequisites

- Windows
- Visual Studio with the **.NET desktop development** workload
- .NET Framework 4.7.2 Developer Pack or a compatible build environment

```bash
git clone https://github.com/mohammadimad/Number-Systems.git
cd Number-Systems
```

Open `Counting systems/Counting systems.sln` in Visual Studio and run the project, or build it from a compatible terminal:

```powershell
dotnet build "Counting systems/Counting systems.sln" --configuration Release
```

## Build Verification

The Release configuration was built locally with:

```text
Build succeeded.
0 Warning(s)
0 Error(s)
```

## Current Scope

This is an educational converter built around integer values. Some cross-base paths first parse the displayed text as a decimal integer instead of normalizing it through the selected source base, and hexadecimal input containing letters needs stronger parsing and validation. These paths should be corrected before treating every conversion combination as production-ready.

## Possible Improvements

- Normalize every conversion through a decimal numeric value.
- Support hexadecimal letters safely and case-insensitively.
- Replace `int.Parse` with non-throwing validation.
- Handle negative numbers and values larger than `Int32`.
- Prevent selecting identical source and target systems.
- Add copy-to-clipboard support and conversion history.
- Add unit tests for every base pair and invalid input.

## Author

[Mohammad Imad Abdelfattah](https://github.com/mohammadimad)
