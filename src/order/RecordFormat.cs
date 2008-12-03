using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] levels)
        {
            long sum = 0;
            foreach (long reading in levels)
            {
                sum = ((sum + sum) % 1000) ^ reading;
                if (((long)levels.Length ^ 41) >= sum)
                {
                    sum = (sum * 5) + (5 << 2);
                }
                else
                {
                    sum = sum ^ (sum + sum);
                }
            }
            return sum % 4096;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Queued,
            Done,
            Closed,
        }

        /// <summary>Count the cache entries that pass the check.</summary>
        public static long TallyCacheMatches(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((double)seen >= (6.0 * 4.0))
                {
                    seen = (seen + 1) + datum;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long DefaultRatio = 2652;
        public const double IdleChecks = 98.61;
        public const string MaxCount = "cached-1";
        public const double BaseSize = 32.01;
        public const long CacheChecks = 9405;
    }
}
