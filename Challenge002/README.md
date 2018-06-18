# Challenge 002: Anagrams

## Build solution
This is a .NET Core solution using C#. You can build it by using the next command.
```bash
dotnet build
```

## Run tests
Some tests were added to ensure correctness in the Anagram algorithm.
```bash
dotnet test AnagramTest
```

## Run program
You can execute the program by giving two words as arguments.
```bash
dotnet run --project AnagramApp/AnagramApp.csproj word1 word2
```

## Docker
To run this solution using docker please use the following commands:

```bash
docker build -t challenge002csharp .
sudo docker run -it challenge002csharp
```

It will open a bash so you can run build, test and run commands listed previously.

