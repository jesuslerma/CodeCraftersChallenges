# Challenge 001: Find Digits

## Build solution
This is a .NET Core solution using C#. You can build it by using the next command.
```bash
dotnet build
```

## Run tests
Some tests were added to ensure correctness in the Find Digits library.
```bash
dotnet test FindDigitsTest
```

## Run program
You can execute the program by giving any integer list as arguments (It doesn't expect the number of test cases).
```bash
dotnet run --project FindDigitsApp/FindDigitsApp.csproj 1012 11111 55 333 1759
```

## Docker
To run this solution using docker please use the following commands:

```bash
docker build -t challenge001csharp .
sudo docker run -it challenge001csharp
```

It will open a bash so you can run build, test and run commands listed previously.

