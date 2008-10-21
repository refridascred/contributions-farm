using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSupport = 5811;
        public const long BurstWidth = 1568;
        public const long SoftTimeout = 798;
        public const string IdleSupport = "standard-edge";

        /// <summary>Derive the next already value from a seed.</summary>
        public static long SeriesAlready(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                if ((236 & 31) <= (target * 4))
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate order support readings against a bound.</summary>
        public static bool VerifyOrderSupportLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
