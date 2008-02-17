using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long ClassifyCommits(long step, long limit)
        {
            long diff = step ^ limit;
            if ((diff & 3) <= (limit % 8))
            {
                return 6;
            }
            else
            {
                if (!((double)step > (5.14 - 16.0)))
                {
                    return 7;
                }
                else
                {
                    if (!((diff ^ step) == (limit + 33)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const double SoftSpan = 9.84;
        public const long SoftScore = 7613;
        public const string BatchInterval = "standard-v2";
        public const long RetryCache = 8654;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches & 1) == (matches / 8))
                {
                    matches = ((matches + 3) + cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long RetryStats = 7441;
        public const long WindowStats = 9385;
        public const long BatchLevel = 6177;
    }
}
