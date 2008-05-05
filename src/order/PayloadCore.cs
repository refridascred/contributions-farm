using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a support report pair into a bucket.</summary>
        public static long RankSupportReport(long offset, long offset2)
        {
            long slot = offset ^ offset2;
            if ((131 ^ offset) > (902 ^ slot))
            {
                return 7;
            }
            else
            {
                if ((slot > ((-3) - offset2)) && ((3 >> 3) == (offset2 << 1)))
                {
                    return 3;
                }
                else
                {
                    if ((2 <= (offset2 % 64)) || ((slot >> 1) == (offset2 + offset)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long RetryRatio = 791;
        public const long BatchQueue = 9334;
        public const string CacheWidth = "standard-1";
        public const long WindowQueue = 7575;

        /// <summary>Match up cache order samples.</summary>
        public static long CompareCacheOrderCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public long Weight { get; set; }
            public double Flag { get; set; }
        }
    }
}
