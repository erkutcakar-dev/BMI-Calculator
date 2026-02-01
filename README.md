# BMI Calculator

<div align="center">

**A modern, cross-platform Body Mass Index calculator built with .NET MAUI**

[![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)](https://dotnet.microsoft.com/)
[![MAUI](https://img.shields.io/badge/MAUI-9.0-blue.svg)](https://dotnet.microsoft.com/apps/maui)
[![Platform](https://img.shields.io/badge/platform-Android%20%7C%20iOS%20%7C%20Windows%20%7C%20macOS-lightgrey.svg)](https://dotnet.microsoft.com/apps/maui)
[![License](https://img.shields.io/badge/license-MIT-green.svg)](LICENSE)

---

</div>

## Overview

BMI Calculator is a beautiful, intuitive mobile and desktop application that helps you calculate and visualize your Body Mass Index. Built with .NET MAUI, this app provides a seamless experience across Android, iOS, Windows, and macOS platforms with an elegant user interface featuring interactive gauges and real-time BMI calculations.

---

## Features

### Interactive Input Controls
- **Height Slider**: Adjust your height using an intuitive linear gauge (100-220 cm)
- **Weight Slider**: Set your weight with a smooth, interactive gauge (40-150 kg)
- **Real-time Updates**: BMI calculation updates instantly as you adjust values

### Visual BMI Display
- **Radial Gauge**: Beautiful circular gauge showing your BMI value
- **Color-coded Ranges**: Visual indicators for different BMI categories:
  - **Blue** (0-18.5): Underweight
  - **Green** (18.5-25): Normal weight
  - **Yellow** (25-30): Overweight
  - **Orange** (30-40): Obese
  - **Red** (40+): Morbidly obese

### BMI Categories
The app automatically categorizes your BMI result:
- Severe Thinness (≤16)
- Underweight (16-18.5)
- Normal (18.5-25)
- Overweight (25-30)
- Obese (30-40)
- Morbid Obese (>40)

### Modern UI Design
- **Gradient Background**: Elegant purple-to-blue gradient
- **Card-based Layout**: Clean, modern card design
- **Responsive Design**: Optimized for all screen sizes
- **Smooth Animations**: Fluid interactions and transitions

---

## Screenshots

<!-- Add your screenshots here -->
<!-- Example format:
![App Screenshot](screenshots/main-screen.png)
![BMI Calculation](screenshots/bmi-result.png)
![Different Platforms](screenshots/platforms.png)
-->

*Screenshots will be added here*

---

## Technology Stack

### Core Technologies
- **.NET 9.0**: Latest .NET framework
- **.NET MAUI**: Multi-platform App UI framework
- **C#**: Primary programming language
- **XAML**: UI markup language

### Key Libraries
- **Syncfusion.Maui.Gauges** (v32.1.25): Interactive gauge controls
- **PropertyChanged.Fody** (v4.1.0): Property change notifications
- **Microsoft.Extensions.Logging.Debug** (v9.0.8): Debug logging

### Architecture
- **MVVM Pattern**: Model-View-ViewModel architecture
- **Data Binding**: Two-way data binding for reactive UI
- **Property Change Notifications**: Automatic UI updates

---

## Platform Support

| Platform | Minimum Version | Status |
|----------|----------------|--------|
| **Android** | API 21 (Android 5.0) | ✅ Supported |
| **iOS** | iOS 15.0 | ✅ Supported |
| **Windows** | Windows 10 17763.0 | ✅ Supported |
| **macOS** | macOS 12.0 (Catalyst) | ✅ Supported |
| **Tizen** | Tizen 6.5 | ⚠️ Optional |

---

## Getting Started

### Prerequisites

Before you begin, ensure you have the following installed:

- [.NET 9.0 SDK](https://dotnet.microsoft.com/download/dotnet/9.0)
- [Visual Studio 2022](https://visualstudio.microsoft.com/) (17.14 or later) with:
  - .NET Multi-platform App UI development workload
  - Platform-specific SDKs (Android SDK, iOS SDK, etc.)

### Installation

1. **Clone the repository**
   ```bash
   git clone https://github.com/erkutcakar-dev/BMI.git
   cd BMI
   ```

2. **Restore NuGet packages**
   ```bash
   dotnet restore
   ```

3. **Build the solution**
   ```bash
   dotnet build BMI.sln
   ```

### Running the Application

#### Windows
```bash
dotnet run --project BMI/BMI.csproj -f net9.0-windows10.0.19041.0
```

#### Android
```bash
dotnet build BMI/BMI.csproj -t:Run -f net9.0-android
```

#### iOS (macOS only)
```bash
dotnet build BMI/BMI.csproj -t:Run -f net9.0-ios
```

#### macOS
```bash
dotnet build BMI/BMI.csproj -t:Run -f net9.0-maccatalyst
```

---

## Project Structure

```
BMI/
├── BMI/
│   ├── MVVM/
│   │   ├── Models/
│   │   │   └── BMI.cs              # BMI calculation model
│   │   ├── ViewModels/
│   │   │   └── BMIViewModel.cs     # ViewModel with business logic
│   │   └── Views/
│   │       └── BMIView.xaml        # Main UI view
│   ├── Platforms/                  # Platform-specific code
│   │   ├── Android/
│   │   ├── iOS/
│   │   ├── Windows/
│   │   └── MacCatalyst/
│   ├── Resources/                  # App resources
│   │   ├── AppIcon/               # Application icons
│   │   ├── Images/                # Image assets
│   │   ├── Fonts/                 # Custom fonts
│   │   └── Styles/                # XAML styles
│   ├── App.xaml                   # Application definition
│   ├── AppShell.xaml              # Shell navigation
│   └── MauiProgram.cs             # App initialization
└── BMI.sln                        # Solution file
```

---

## How It Works

### BMI Calculation

The Body Mass Index is calculated using the standard formula:

```
BMI = (Weight in kg) / (Height in meters)²
```

In the application, height is entered in centimeters and converted automatically:

```csharp
BMI = ((Weight / Height) / Height) * 10000
```

### MVVM Architecture

- **Model** (`BMI.cs`): Contains the BMI calculation logic and result categorization
- **ViewModel** (`BMIViewModel.cs`): Manages the BMI model instance and provides data binding
- **View** (`BMIView.xaml`): Defines the UI with interactive gauges and displays

### Real-time Updates

Using PropertyChanged.Fody, the UI automatically updates when BMI values change, providing instant feedback as users adjust height and weight sliders.

---

## Customization

### Changing Color Scheme

Edit the gradient colors in `BMIView.xaml`:

```xml
<LinearGradientBrush EndPoint="0,1">
    <GradientStop Color="#572334" Offset="0" />
    <GradientStop Color="#a594f9" Offset="1" />
</LinearGradientBrush>
```

### Adjusting Gauge Ranges

Modify the minimum and maximum values in the gauge definitions:

```xml
<gauge:SfLinearGauge
    Minimum="100"
    Maximum="220"
    Interval="20">
```

### BMI Category Thresholds

Update the thresholds in `BMI.cs`:

```csharp
if (value <= 18.5f)
    return "Underweight";
// ... other thresholds
```

---

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request. For major changes, please open an issue first to discuss what you would like to change.

### Contribution Guidelines

1. Fork the repository
2. Create your feature branch (`git checkout -b feature/AmazingFeature`)
3. Commit your changes (`git commit -m 'Add some AmazingFeature'`)
4. Push to the branch (`git push origin feature/AmazingFeature`)
5. Open a Pull Request

---

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE) file for details.

---

## Acknowledgments

- Built with [.NET MAUI](https://dotnet.microsoft.com/apps/maui)
- UI components powered by [Syncfusion](https://www.syncfusion.com/)
- Icons and assets from Microsoft MAUI templates

---

## Contact & Support

For questions, issues, or suggestions, please open an issue on GitHub.

---

<div align="center">

**Made with .NET MAUI**

[Report Bug](https://github.com/erkutcakar-dev/BMI/issues) · [Request Feature](https://github.com/erkutcakar-dev/BMI/issues) · [Documentation](https://github.com/erkutcakar-dev/BMI/wiki)

</div>

## Images
<img width="393" height="879" alt="Ekran görüntüsü 2026-02-01 135359" src="https://github.com/user-attachments/assets/934279b1-83f8-4b6f-8e36-e387726b3f8f" />

## Images
<img width="407" height="918" alt="Ekran görüntüsü 2026-02-01 135423" src="https://github.com/user-attachments/assets/665091de-19f8-4e54-9f06-a6596b7e92a4" />

## Images
<img width="398" height="913" alt="Ekran görüntüsü 2026-02-01 135452" src="https://github.com/user-attachments/assets/789acfa3-9cde-4cad-88d8-c4e26cb99ae0" />

## Images
<img width="404" height="841" alt="Ekran görüntüsü 2026-02-01 135440" src="https://github.com/user-attachments/assets/0fcf549e-08c9-4e41-a275-3d007c83df09" />


