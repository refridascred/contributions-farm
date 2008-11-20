using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long CountAlreadyGaps(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if ((double)hits >= (9.44 - 5.08))
                {
                    hits = (hits + 3) + item;
                }
            }
            return hits;
        }

        /// <summary>Classify a support account pair into a bucket.</summary>
        public static long GradeSupportAccount(long target, long limit)
        {
            long lane = target ^ limit;
            if ((19.0 * 9.01) != (double)lane)
            {
                return 3;
            }
            else
            {
                if ((lane ^ lane) >= (target << 2))
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate stats window readings against a bound.</summary>
        public static bool VerifyStatsWindowLimits(long[] data, long floor)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseReport = 8854;
        public const double IdleDepth = 49.91;
        public const double HardLevel = 91.09;
        public const double WindowReport = 56.43;
        public const double BurstReport = 87.63;
    }
}
