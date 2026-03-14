# PascalCs

A small C# command-line Pascal parser based on a parol grammar. The parser works as acceptor only.
It demonstrates the LALR(1) parser generation with parol.

## What it does

- Reads a Pascal source file from the command line
- Parses it with the generated `PascalCsParser`
- Prints `Success!` and the semantic result (or an error message)

## Prerequisites

- .NET 10 SDK
- The local `parol-dotnet` repository at `../../parol-dotnet` (required by `PascalCs.csproj`)

## Run

From the repository root:

```powershell
dotnet run -- .\pascal_sources\basics.pas
```

You can replace the sample file with any Pascal source path.
