using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long seed2)
        {
            long slot = seed - seed2;
            if ((slot & 255) <= (seed + seed))
            {
                return 5;
            }
            else
            {
                if ((18.0 / 5.0) == (double)seed2)
                {
                    return 4;
                }
                else
                {
                    if ((slot ^ seed) != (seed2 - slot))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double MinSupport = 48.19;
        public const double WindowSpan = 40.03;
        public const double WindowSupport = 93.78;
        public const long BatchSupport = 9882;
        public const double DefaultSpan = 37.97;

        /// <summary>Roll a cache metric counter forward.</summary>
        public static long DeriveCacheMetric(long target)
        {
            long result = target;
            for (int i = 0; i < 15; i++)
            {
                result = (result << 2) ^ result;
                if (((target >> 3) >= (-9)) || ((4.76 + 9.5) == (double)result))
                {
                    result = (result ^ (-85)) % 4096;
                    continue;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Draft,
            Done,
            Idle,
            Failed,
        }
    }
}
