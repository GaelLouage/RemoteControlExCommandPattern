Remote Control Command Pattern Example

This project demonstrates the implementation of the Command Pattern using a simple remote control that can execute commands like turning on/off lights and fans. The project is built with C# and WPF for the user interface.
Table of Contents

    Overview
    Architecture
    Features
    Usage
    Code Structure
    Installation
    Contributing
    
Overview

This project is a basic implementation of the Command Pattern, a behavioral design pattern that encapsulates requests as objects, allowing you to parameterize clients with different requests, queue them, and log them, and support undoable operations.
Architecture

The project consists of the following key components:

    ICommand Interface: Defines the Execute() method that all command classes implement.
    Command Classes: LightOnCommand, LightOffCommand, FanOnCommand, and FanOffCommand implement the ICommand interface to perform specific actions.
    RemoteControl Class: Acts as the invoker, holding a reference to a command and executing it.
    RemoteControl Extensions: Extension methods to simplify command execution based on an enumeration of command types.
    WPF UI: Provides a simple interface with buttons to control the lights and fans.

Features

    Command Pattern Implementation: Encapsulates requests as command objects.
    Modular Design: Easily extendable to add more commands or modify existing ones.
    User Interface: A WPF-based UI with buttons to trigger the commands.

Usage

To use the remote control application:

    Light On: Turns the light on.
    Light Off: Turns the light off.
    Fan On: Turns the fan on.
    Fan Off: Turns the fan off.

Example UI Interaction

    Press the "Light On" button to execute the LightOnCommand.
    Press the "Fan Off" button to execute the FanOffCommand.

Code Structure

The project is structured as follows:

RemoteControlEx/
├── Command/
│   ├── Interfaces/
│   │   └── ICommand.cs
│   └── Classes/
│       ├── FanOffCommand.cs
│       ├── FanOnCommand.cs
│       ├── LightOffCommand.cs
│       └── LightOnCommand.cs
├── Enums/
│   └── CommandType.cs
├── Extensions/
│   └── RemoteControlExtensions.cs
├── Models/
│   └── RemoteControl.cs
├── MainWindow.xaml
└── MainWindow.xaml.cs

Key Files

    ICommand.cs: Interface for command pattern.
    CommandType.cs: Enumeration of command types (Light On/Off, Fan On/Off).
    RemoteControl.cs: Main class that invokes commands.
    RemoteControlExtensions.cs: Contains extension methods for the RemoteControl class.
    MainWindow.xaml / MainWindow.xaml.cs: WPF UI and code-behind for the user interface.

Installation

To run the project locally:

    Clone the repository:

    bash

    git clone https://github.com/yourusername/RemoteControlEx.git

    Open the solution file (RemoteControlEx.sln) in Visual Studio.
    Build the project.
    Run the application.

Contributing

Contributions are welcome! Please fork the repository and submit a pull request for any improvements, bug fixes, or new features.
