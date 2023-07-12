# Proxfield.Parallel

Paralelize tasks across multiple threads assyncronously.

*Be aware*: this library takes advantages of systems with multiple threads/cores, if your system only have one core the performance could be detrimental.

```csharp
await Parallelize.ParallelForEachAsync(myList, async (_) =>
{
    // DO STUFF HERE
},
DegreeOfParallelization.High);
```

Degree of paralelization:

```csharp
public const int Low = 1;
public const int Medium = 10;
public const int High = 100;
```

* DegreeOfParallelization.Low: utilizes a single thread;
* Medium: utilizes up to 10 concurrent threads;
* High: utilizes up to 100 concurrent threads.