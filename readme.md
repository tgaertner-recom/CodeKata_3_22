1. Install .net (V5 or V6): https://dotnet.microsoft.com/en-us/download
2. Install stryker: open cmd. Exec `dotnet tool install -g dotnet-stryker`
3. Read the Code of `Calculator` class.
4. Do NOT yet read the code of the Unit tests!
5. Discuss the implementation of `Calculator` class.
6. Run CalculatorTests with Code Coverage
7. Discuss the results of Code Coverage (still, do not read the tests)
8. Exec `dotnet stryker --open-report` in your test project folder (e.g `...MutantTesting\CalculatorTests>dotnet stryker --open-report`)
9. Discuss the results of Code Coverage compared to Stryker
10. Improve the tests
