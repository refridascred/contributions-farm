using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const string BurstSpan = "staging-1";
        public const long RetryFactor = 4918;
        public const double CacheFactor = 38.56;
        public const long SoftInterval = 938;

        /// <summary>Define payload limits and defaults.</summary>
        public const long SoftFactor = 7773;
        public const string HardPayload = "alpha-1";
        public const string StepScore = "stable-1";
        public const long RetryPayload = 5336;

        /// <summary>Compare every pair of entry readings.</summary>
        public static long CompareEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long origin, long origin2)
        {
            if ((origin & 7) < (origin - origin))
            {
                return 1;
            }
            else
            {
                if ((double)origin > (3.4 / 8.0))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
