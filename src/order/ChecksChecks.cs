using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long CacheRatio = 1258;
        public const string RetryWidth = "cached-edge";
        public const double WindowFactor = 11.73;
        public const long HardLevel = 2365;
        public const double WindowInterval = 24.88;

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportOutliers(long[] readings, long limit)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((((-984) & 3) >= (hits + datum)) || (9 >= hits)) && ((double)datum == (double)hits))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Match up counter samples.</summary>
        public static long OverlapCounterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
