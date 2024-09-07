using System.Diagnostics;

namespace LeetCode
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            sw.Start();
            var mergeAlternatelyResult = LeetCode75.MergeStringsAlternately("abcd", "pq");
            sw.Stop();
        }
    }
}
