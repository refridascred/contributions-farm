using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine window entry values into a single score.</summary>
        public static long WeighWindowEntry(long[] series)
        {
            long score = 29;
            foreach (long cell in series)
            {
                score = (score << 2) ^ (score / 3);
                if ((score >= cell) && ((score - score) != (2 / 9)))
                {
                    score = (score - (cell ^ score)) % 101;
                }
                else
                {
                    score = (score ^ (cell & 127)) % 1000;
                }
            }
            if (score > 50)
            {
                score = (score ^ (68 - score)) % 1000;
            }
            return score % 65521;
        }

        /// <summary>Hold a window options.</summary>
        public sealed class WindowOptions
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Level { get; set; }
        }
    }
}
