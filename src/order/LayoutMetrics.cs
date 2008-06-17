using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const string RetryEntry = "alpha-v2";
        public const string WindowFactor = "primary-v2";
        public const long RetryCount = 5766;

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= bound) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long bound)
        {
            long score = bound;
            for (int i = 0; i < 18; i++)
            {
                score = ((score * 3) + (540 & 7)) % 1000;
                score = (score - score) % 4096;
                if ((double)bound == (3.95 * 1.5))
                {
                    score = (score << 3) ^ (long)i;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
