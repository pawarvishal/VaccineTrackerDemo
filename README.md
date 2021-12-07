# VaccineTrackerDemo
## Problem Statement
This project is to be able to register a user for vaccination and display appropriate steps for users to be followed during vaccination. Create a new solution with appropriate name. Add a new WinForms Project.


## Summary
This project contains Windows Form which accepts the basic information about the user for vaccination and saves the data in MSSQL Server database afer user confirmation.
There is button provided to fetch all the users who have registered for vaccination.


## Modules
### Common Module
This module contains VaccineUser Domain Model and IVaccineUserDataProvider which are used throughout the application.

### DataAccess Module
This module contains SQLVaccineUserDataProvider and DummyVaccineUserDataProvider implementations.
SQLVaccineUserDataProvider use SQLClient to connect to MSSQL Server to save and fetch the user data.

### Viewmodels Module
This module contains different MainViewModel and VaccineUserViewModel for UI.

### WinForms Module
This module contains the Windows Forms UI to Register, Save and Fetch vaccine user data.

### Tests Module
This module contains the Unit Tests for ViewModels and DataAccess.
