using NUnit.Framework;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Proxfield.Parallel.Tests
{
    public class ParallelizeTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public async Task ParallelForEachAsync_WhenListIsFull()
        {
            List<string> entries = new List<string>()
            {
                "A", "B", "C", "D", "E", "F", 
                "G", "H", "I", "J", "K", "L"
            };

            int total = entries.Count;
            int sum = 0;

            await Parallelize.ParallelForEachAsync(entries, (_) =>
            {
                sum += 1;
                return Task.CompletedTask;
            });

            Assert.That(sum, Is.EqualTo(total));
        }
    }
}