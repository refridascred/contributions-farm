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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferMatches(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value + value) != (value ^ 16))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
