# Proxfield.Parallel

Parallelize tasks across multiple threads asynchronously.

*Be aware*: this library takes advantage of systems with multiple threads/cores, if your system only have one core the performance could be detrimental.

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
