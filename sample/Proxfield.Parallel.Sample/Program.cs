using Proxfield.Parallel;

List<string> letters = new()
{
    "A", "B", "C", "D", "E", "F", "G"
};

await Parallelize.ParallelForEachAsync(letters, async (_) =>
{
    // DO STUFF HERE
});