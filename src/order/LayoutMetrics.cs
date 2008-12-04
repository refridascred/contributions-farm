using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultFactor = "alpha-1";
        public const long LimitToken = 9281;
        public const long CacheTimeout = 3815;
        public const long HardToken = 2529;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsBounds(long[] items, long step)
        {
            bool ok = true;
            foreach (long item in items)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long OverlapMetricCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
