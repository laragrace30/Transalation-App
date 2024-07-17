# Transalation App
## Description
The Translation App is a Windows Forms application that allows users to translate text between different languages using an external translation API. The app provides a user-friendly interface for selecting source and target languages, entering text to be translated, and displaying the translated text.

## Prerequisites
- Visual Studio (2019 or later)
- .NET Framework (4.7.2 or later)

## Setup Instructions

### 1. Clone the Repository
Clone the repository to your local machine using the following command:
git clone https://github.com/yourusername/translation-app.git

### 2. Open the Project in Visual Studio
Open Visual Studio.
Select File -> Open -> Project/Solution.
Navigate to the cloned repository folder and open the TranslationApp.sln file.

### 3. Restore NuGet Packages
Right-click on the solution in the Solution Explorer and select Restore NuGet Packages.
Ensure the required packages, including Newtonsoft.Json and DetectLanguage, are installed.

### 4. Build the Project
Click on Build -> Build Solution or press Ctrl+Shift+B to build the project.
Make sure there are no build errors.

### 5. Run the Application
Click on Debug -> Start Debugging or press F5 to run the application.
The Translation App should launch, allowing you to enter text, select languages, and translate.

## Usage
Select Languages: Use the dropdown menus to select the source and target languages.
Enter Text: Type the text you want to translate in the input textbox.
Translate: Click the Translate button to fetch and display the translated text in the output textbox.
Swap Languages: Click the Swap button to swap the source and target languages along with the text in the textboxes.
Language Detection: The app automatically detects the language of the input text.
API Request Failures: Ensure you have a valid API key and internet connection.
Language Detection Issues: Check if the input text is clear and in a supported language.

