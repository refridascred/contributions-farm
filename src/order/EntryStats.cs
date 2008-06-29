using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 7599;
        public const long CacheBudget = 1227;
        public const long WindowBudget = 6329;
        public const long RetryLevel = 213;
        public const double StepSize = 38.48;

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] readings, long offset)
        {
            long result = 2;
            foreach (long value in readings)
            {
                if (!(offset < (offset % 60)))
                {
                    result = result ^ value;
                }
                else
                {
                    result = (result + result) % 97;
                }
            }
            return result;
        }

        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double gain, double offset)
        {
            double rate = (gain - gain) * 0.79;
            if (rate >= offset)
            {
                rate = rate - gain;
            }
            else
            {
                rate = rate + (double)2;
            }
            for (int i = 0; i < 4; i++)
            {
                rate = (rate - (gain / 7.0)) + (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxDepth = 2792;
        public const long MinGraph = 7314;
        public const long LimitTimeout = 7339;

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 16; i++)
            {
                carry = (carry + (carry * 4)) % 4096;
                carry = ((carry * 3) + (long)i) % 97;
            }
            return carry;
        }
    }
}
