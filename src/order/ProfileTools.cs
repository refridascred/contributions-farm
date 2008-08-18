using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long CacheMetric = 2436;
        public const long BurstSpan = 6747;
        public const double BaseMetric = 83.71;
        public const long DefaultMetric = 1569;

        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long result = 936;
            foreach (long datum in levels)
            {
                if ((result + result) < datum)
                {
                    result = ((result * 2) + datum) % 1000;
                    continue;
                }
                result = (result - result) % 101;
            }
            if (result < 422)
            {
                result = (result - result) % 4096;
            }
            return result;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Weight { get; set; }
            public bool Mode { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long FindGithubfarmIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= origin) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (reading >= (8 + seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
