<p align="center">
<img src="https://github.com/proxfield/Proxfield.Parallel/assets/7343019/d756bcc1-c195-44b0-a171-f462c65c963c" />
</p>

Parallelize tasks across multiple threads asynchronously.

![GitHub License](https://img.shields.io/github/license/proxfield/Proxfield.Parallel)
![Actions](https://github.com/proxfield/Proxfield.Parallel/actions/workflows/build.yml/badge.svg)
[![Nuget](https://github.com/proxfield/Proxfield.Parallel/actions/workflows/release.yml/badge.svg)](https://github.com/proxfield/Proxfield.Extensions.Caching.SQLite/actions/workflows/release.yml)
![GitHub branch checks state](https://img.shields.io/github/checks-status/proxfield/Proxfield.Parallel/main)
![GitHub code size in bytes](https://img.shields.io/github/languages/code-size/proxfield/Proxfield.Parallel)

*Be aware*: this library takes advantage of systems with multiple threads/cores, if your system only have one core the performance could be detrimental.

## Packages

Packages and versions available at the Nuget Galery.


| Package | Version | Downloads |
| - | - | - |
| <b>Proxfield.Parallel</b> | [![Nuget version](https://img.shields.io/nuget/v/Proxfield.Parallel)](https://www.nuget.org/packages/Proxfield.Parallel/) | [![Nuget downloads](https://img.shields.io/nuget/dt/Proxfield.Parallel)](https://www.nuget.org/packages/Proxfield.Parallel/) |

## Nuget

```bash
PM> Install-Package Proxfield.Parallel
```

Visit out project at the [Nuget Repository Page](https://www.nuget.org/packages/Proxfield.Parallel) to know more.

## How

```csharp
await Parallelize.ParallelForEachAsync(myList, async (_) =>
{
    // DO STUFF HERE
},
DegreeOfParallelization.High);
```

Degree of parallelization:

```csharp
public const int Low = 1;
public const int Medium = 10;
public const int High = 100;
```

* DegreeOfParallelization.Low: utilizes a single thread;
* Medium: utilizes up to 10 concurrent threads;
* High: utilizes up to 100 concurrent threads.

## Platform Support

Parallel is compiled for the following versions of frameworks:

- [X] DotNet 6
- [x] DotNet 5
- [x] DotNet Core 3.1

## License
![GitHub License](https://img.shields.io/github/license/proxfield/Proxfield.Parallel)

The MIT License ([MIT](LICENSE.md)) - Copyright (c) 2022-2023 Proxfield Consulting Group and its affiliates
