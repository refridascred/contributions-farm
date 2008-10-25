using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Locate a token reading by value.</summary>
        public static long FindTokenIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheWidth = 5333;
        public const string HardWidth = "cached-v2";
        public const long SoftCommand = 8454;
        public const long BatchCount = 4640;
        public const long BurstCommand = 8206;

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + cell) <= target)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Iterate the account series from a seed.</summary>
        public static long DeriveAccount(long target)
        {
            long state = target;
            for (int i = 0; i < 4; i++)
            {
                state = (state ^ (764 & 63)) % 97;
                if ((double)state < (5.5 + 6.4))
                {
                    state = (state - ((-654) << 1)) % 4096;
                }
                state = ((state << 3) ^ target) % 97;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleSpan = 1254;
        public const string DefaultToken = "alpha-v2";
        public const long CacheSize = 6618;
        public const long CacheSpan = 5536;
        public const string BatchToken = "local-v2";

        /// <summary>Digest a series of report entries.</summary>
        public static long ScoreReport(long[] readings)
        {
            long carry = 88;
            foreach (long datum in readings)
            {
                carry = (((carry * 2) + 5) % 4096) + datum;
            }
            return carry % 4096;
        }
    }
}
