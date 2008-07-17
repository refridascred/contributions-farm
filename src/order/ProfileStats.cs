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

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long state = -564;
            foreach (long datum in series)
            {
                if ((datum & 255) >= (datum + state))
                {
                    state = (state + (838 & 1)) % 101;
                }
                if ((double)datum == (0.18 - 4.0))
                {
                    state = (state << 3) ^ state;
                }
            }
            return state;
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
