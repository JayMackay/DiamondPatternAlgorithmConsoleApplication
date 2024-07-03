# Diamond Pattern Algorithm Console Application

This is a .Net Framework console application that demonstrates the generation of a diamond pattern when given a character from the alphabet, based on a post by Seb Rose. 

For more information, you can visit the website by clicking [HERE](http://claysnow.co.uk/recycling-tests-in-tdd/).

To submit bug reports, feature suggestions, or track changes go to:
https://github.com/JayMackay/DiamondPatternAlgorithmConsoleApplication

### Contents Of This File

-   Requirements
-   Features
-   Installation
-   Problem

### Requirements

This project uses .Net Framework 4.6.2, ensure you have the necessary version installed to build and run the application which can be found **_[HERE](https://dotnet.microsoft.com/en-us/download/dotnet-framework)_**

Git link for cloning the repository https://github.com/JayMackay/DiamondPatternAlgorithmConsoleApplication.git

### Features

This application serves as a practical example of leveraging modern C# features and design patterns to enhance code clarity, maintainability, and testing practices

- LINQ: Utilizes LINQ to generate a diamond pattern, showcasing its capability to streamline operations on data structures like arrays
- Dependency Injection: Demonstrates the use of dependency injection, enhancing modularity and testability by decoupling components and facilitating easier integration of services
- Moq: Uses Moq for mocking dependencies in unit tests, ensuring isolated and controlled testing environments to verify application functionality without external dependencies

### Installation

**Step 1: Clone the Repository**

Clone the repository to your local machine using Git:

```
git clone <repository-url>
```

_Replace <repository-url> with the actual URL of the Git repository_


**Step 2: Navigate to the Project Directory**

Open a terminal or command prompt and navigate into the project directory:

```
cd DiamondPatternAlgorithmConsoleApplication
```


**Step 3: Build the Solution**

Build the solution using Visual Studio or .Net CLI:

Using Visual Studio:
Open the solution file (DiamondPatternAlgorithmConsoleApplication.sln) in Visual Studio and build the solution

Using .Net CLI
Run the following command in your terminal or command prompt:

```
dotnet build
```

### Problem

Given a character from the alphabet, print a diamond of its output with that character being the midpoint of the diamond.

Examples

    > diamond.exe A
      A

    > diamond.exe B
       A
      B B
       A

    > diamond.exe C
        A
       B B
      C   C
       B B
        A

Visual representation of the whitespace in the rendering:

    > diamond.exe C
    _ _ A _ _
    _ B _ B _
    C _ _ _ C
    _ B _ B _
    _ _ A _ _


