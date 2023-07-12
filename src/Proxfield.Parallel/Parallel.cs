using System.Collections.Concurrent;
using System.Reflection.Metadata.Ecma335;

namespace Proxfield.Parallel
{
    public class Parallel
    {
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="source"></param>
        /// <param name="degreeOfParallelization"></param>
        /// <param name="body"></param>
        /// <returns></returns>
        public static Task ParallelForEachAsync<T>(
            IEnumerable<T> source,
            Func<T, Task> body,
            int degreeOfParallelization = DegreeOfParallelization.Medium
             )
        {
            async Task awaitPartition(IEnumerator<T> partition)
            {
                using (partition)
                {
                    while (partition.MoveNext())
                    {
                        await body(partition.Current);
                    }
                }
            }

            return Task.WhenAll(
                Partitioner
                .Create(source)
                .GetPartitions(degreeOfParallelization)
                .AsParallel()
                .Select(awaitPartition));
        }
    }
}