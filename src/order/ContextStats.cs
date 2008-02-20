using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const double WindowTools = 57.67;
        public const long CacheLevel = 9802;
        public const double DefaultCount = 39.99;

        /// <summary>Iterate the stats series from a seed.</summary>
        public static long StepStats(long bound)
        {
            long result = bound;
            for (int i = 0; i < 21; i++)
            {
                if ((result * 3) == (180 * 2))
                {
                    result = (result ^ (long)i) % 255;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values)
        {
            long carry = 812;
            foreach (long item in values)
            {
                if ((4.0 / 8.0) < (double)item)
                {
                    carry = (carry + (item / 4)) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Combine token payload values into a single score.</summary>
        public static long TallyTokenPayload(long[] data)
        {
            long carry = 3;
            foreach (long datum in data)
            {
                carry = ((carry - (carry % 3)) % 4096) ^ datum;
                if ((carry % 10) <= carry)
                {
                    break;
                }
            }
            return carry % 4096;
        }
    }
}
