# USB Control Application

## Overview
The USB Control Application is designed to monitor and manage USB device connections, ensuring unauthorized access is prevented through password protection and a whitelist of trusted devices. This application enhances security by controlling USB access based on user-defined settings.

## Features
- **USB Device Monitoring**: Detects new USB device connections and checks against a whitelist.
- **Password Protection**: Requests a password for unauthorized devices and validates it securely.
- **Whitelist Management**: Allows users to add or remove devices from a trusted list.
- **Logging**: Records all activities related to USB connections and password validation in a log file.
- **User Interface**: Provides a user-friendly interface for managing settings and monitoring device status.

## Project Structure
```
USBControlApp
├── src
│   ├── Program.cs
│   ├── App.xaml.cs
│   ├── Views
│   │   ├── MainWindow.xaml
│   │   ├── MainWindow.xaml.cs
│   │   ├── PasswordPrompt.xaml
│   │   ├── PasswordPrompt.xaml.cs
│   │   ├── SettingsWindow.xaml
│   │   ├── SettingsWindow.xaml.cs
│   └── Models
│       ├── Device.cs
│       ├── LogEntry.cs
│       └── Config.cs
├── Config
│   └── config.json
├── Logs
│   └── log.json
├── USBControlApp.csproj
├── appsettings.json
└── README.md
```

## Setup Instructions
1. **Clone the Repository**: 
   ```
   git clone https://github.com/amir13872/USB-Control-Application.git
   ```
2. **Navigate to the Project Directory**:
   ```
   cd USBControlApp
   ```
3. **Build the Project**: Use your preferred IDE or command line to build the project.
4. **Run the Application**: Execute the application to start monitoring USB devices.

## Usage Guidelines
- Upon starting the application, ensure to configure the initial settings, including the password and trusted devices.
- Monitor the application for any unauthorized USB connections and respond to password prompts as necessary.
- Regularly check the log file for a history of USB activities and password validation attempts.

## Contributing
Contributions are welcome! Please submit a pull request or open an issue for any enhancements or bug fixes.

## License
This project is licensed under the MIT License. See the LICENSE file for more details.
