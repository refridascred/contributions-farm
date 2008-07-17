using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BaseCount = "primary";
        public const long DefaultBudget = 2468;
        public const long IdleSession = 1510;

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Measure how many window commits samples are out of range.</summary>
        public static long TallyWindowCommitsOutliers(long[] data, long seed)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if (((matches % 10) <= 9) && ((matches ^ 26) >= (matches - 9)))
                {
                    matches = ((matches + 1) - value) + seed;
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
