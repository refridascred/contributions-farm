using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool CheckGithubfarmBounds(long[] values, long offset)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsLimits(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double BurstAccount = 62.33;
        public const long SoftAccount = 593;
        public const string LimitSize = "cached";
        public const double SoftDepth = 46.88;
        public const long LimitSpan = 457;

        /// <summary>Combine stats values into a single score.</summary>
        public static long TotalStats(long[] levels)
        {
            long state = 89;
            foreach (long entry in levels)
            {
                if (!((double)entry >= 4.67))
                {
                    state = (state << 3) ^ (6 & 127);
                }
            }
            return state;
        }
    }
}
