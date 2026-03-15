# PascalCs

> Note: You need to have parol >= 4.3.4 installed to compile this project successfully.

A small C# command-line Pascal parser based on a parol grammar. The parser works as acceptor only.
It demonstrates the LALR(1) parser generation with parol.

## What it does

- Reads a Pascal source file from the command line
- Parses it with the generated `PascalCsParser`
- Prints `Success!` and the semantic result (or an error message)

## Prerequisites

- .NET 10 SDK
- Windows with .NET Framework 4.8 runtime (for `net48` execution)
- The local `parol-dotnet` repository at `../../parol-dotnet` (required by `PascalCs.csproj`)

## Target frameworks

- `net10.0`
- `net48`

## Run

From the repository root:

```powershell
dotnet run -f net10.0 -- .\pascal_sources\basics.pas
dotnet run -f net48 -- .\pascal_sources\basics.pas
```

You can replace the sample file with any Pascal source path.
