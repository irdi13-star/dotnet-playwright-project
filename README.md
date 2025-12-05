# Playwright .NET Demo

This is a sample project demonstrating automated testing with Playwright and .NET.

## Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio Code with C# Dev Kit extension

### Installation

1. Clone the repository
2. Install dependencies:
   ```bash
   dotnet restore
   dotnet build
   ```

3. Install Playwright browsers:
   ```bash
   # Windows (PowerShell)
   pwsh bin/Debug/net8.0/playwright.ps1 install

   # Linux/Mac
   playwright install
   ```

### Running Tests

```bash
# Run all tests
dotnet test

# Run tests with detailed output
dotnet test --logger "console;verbosity=detailed"
