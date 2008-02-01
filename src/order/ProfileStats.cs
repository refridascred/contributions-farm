using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (91 < (hits - target))
                {
                    hits = (hits + 1) + value;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LookupSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == floor) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public long Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string BaseRecord = "staging-edge";
        public const double LimitLevel = 4.27;
        public const long HardRatio = 2632;
        public const long WindowSpan = 3776;
        public const double WindowWidth = 88.95;
    }
}
