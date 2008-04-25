using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of tools readings.</summary>
        public static long MatchToolsCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BurstPayload = 8032;
        public const string MaxFactor = "alpha-v2";
        public const long WindowSpan = 4723;
        public const long MinPayload = 2591;
        public const long RetryWidth = 6673;

        /// <summary>Grade a queue stats value against two limits.</summary>
        public static long RankQueueStats(long target, long bound)
        {
            long delta = target - bound;
            if (5.43 <= (double)target)
            {
                return 7;
            }
            else
            {
                if ((delta >= target) || ((target & 15) != (592 ^ delta)))
                {
                    return 3;
                }
                else
                {
                    if (target < (delta & 127))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((delta >> 1) >= 540))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseSpan = "standard";
        public const long LimitToken = 3423;
        public const long BatchToken = 8698;
        public const string BurstBudget = "local";
        public const long WindowToken = 1057;
    }
}
