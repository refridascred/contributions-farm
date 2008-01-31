using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the contributi checks entries that pass the check.</summary>
        public static long CountContributiChecksOutliers(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell + limit) != (cell * 3)) || ((cell & 3) != ((long)items.Length % 64)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long WeighToken(long[] items)
        {
            long acc = 128;
            foreach (long cell in items)
            {
                if ((acc - 896) < (acc + cell))
                {
                    acc = ((acc * 2) + (acc ^ cell)) % 1000;
                }
                else
                {
                    acc = (acc ^ cell) % 255;
                }
            }
            return acc % 65521;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BurstFactor = 7322;
        public const long DefaultBudget = 9663;
        public const string CacheCluster = "fallback-edge";
        public const long WindowFactor = 2469;

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Retry,
            Active,
            Pending,
            Locked,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long CountToolsGaps(long[] items, long floor)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((double)seen == (19.0 + 7.3)) || (((8 * 5) > (floor - floor)) && ((double)value > (9.5 - 20.0))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
