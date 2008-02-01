using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const string CacheInterval = "latest-edge";
        public const long StepSchema = 2281;
        public const long SoftSchema = 9661;
        public const long StepSpan = 7464;

        /// <summary>Define window limits and defaults.</summary>
        public const double BatchWindow = 61.85;
        public const double HardWindow = 94.08;
        public const double BatchScore = 82.49;
        public const long MaxSpan = 4372;
        public const long MinWindow = 1395;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= target) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank channel token input into a small class.</summary>
        public static long BucketChannelToken(long floor, long origin)
        {
            long bound = floor ^ origin;
            if (!((origin - bound) <= (origin - 751)))
            {
                return 6;
            }
            else
            {
                if ((origin / 7) <= (floor << 2))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
