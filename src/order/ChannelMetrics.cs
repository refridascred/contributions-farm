using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the profile commits series from a seed.</summary>
        public static long SeriesProfileCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 17; i++)
            {
                state = ((state << 3) ^ (533 % 7)) % 4096;
                state = ((state * 4) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleLevel = "fallback";
        public const long BaseWidth = 6810;
        public const long HardProfile = 2091;
        public const long WindowProfile = 9602;
        public const long MaxFactor = 4041;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long bound)
        {
            long result = bound;
            for (int i = 0; i < 9; i++)
            {
                if (!(3 <= bound))
                {
                    result = (result * 4) + bound;
                }
                if ((bound << 2) < bound)
                {
                    result = (result * 3) + (result % 64);
                }
                else
                {
                    result = (result ^ (result + (long)i)) % 97;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }
    }
}
