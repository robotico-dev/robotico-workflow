# Robotico.Workflow

[![.NET 8](https://img.shields.io/badge/.NET-8.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/download/dotnet/8.0)
[![.NET 10](https://img.shields.io/badge/.NET-10.0-512BD4?logo=dotnet)](https://dotnet.microsoft.com/download/dotnet/10.0)
[![GitHub Packages](https://img.shields.io/badge/GitHub%20Packages-Robotico.Workflow-blue?logo=github)](https://github.com/robotico-dev/robotico-workflow-csharp/packages)

Long-running workflow with state machine, step persistence, and durability. Result-based. Depends on Robotico.Result. Separate from Robotico.Saga (compensation).

## Robotico dependencies

```mermaid
flowchart LR
  A[Robotico.Workflow] --> B[Robotico.Result]
```

## Installation

```bash
dotnet add package Robotico.Workflow
```

## License

See repository license file.
