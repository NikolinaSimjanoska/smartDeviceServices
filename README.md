# Smart Devices System

This project implements a smart device control system for managing smart devices such as smartphones and smartwatches. The system allows users to monitor and control various aspects of these devices remotely through web services.

## Overview

The system consists of two main microservices:

1. **TelephonService**: A microservice responsible for handling operations related to smartphones, such as retrieving device information, adjusting settings, and accessing sensor data.
2. **WatchService**: A microservice dedicated to managing smartwatches, including functionalities like retrieving device details, monitoring heart rate, and accessing skin temperature data.

## Technologies Used

The project utilizes the following technologies:

- **C#**: The primary programming language used for development.
- **WCF (Windows Communication Foundation)**: WCF is employed to implement the web services that facilitate communication between clients and the smart devices.

## How to Use

To utilize the smart device control system, follow these steps:

1. Clone the repository to your local machine.
2. Open the solution in Visual Studio.
3. Build the solution to ensure all dependencies are resolved.
4. Run the `Program.cs` file in the `Program` project to start the main program.
5. Interact with the program through the console interface to access different functionalities, such as retrieving device information and managing sensors.
