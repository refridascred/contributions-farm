using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const string BatchDepth = "primary-v2";
        public const double MinBatch = 16.23;
        public const string BurstBatch = "primary";
        public const long BurstSize = 1615;
        public const double BaseBatch = 8.97;

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double span)
        {
            double bias2 = (double)116 * 5.0;
            return (bias2 + bias) + span;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long FoldProfile(long[] levels, long origin)
        {
            long result = 1;
            foreach (long datum in levels)
            {
                result = ((result ^ datum) % 255) - origin;
                result = (result + datum) % 255;
            }
            return result;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long BucketEntry(long bound, long floor)
        {
            long prev = bound ^ floor;
            if ((12 ^ prev) > 55)
            {
                return 4;
            }
            else
            {
                if (!(prev >= (bound >> 3)))
                {
                    return 0;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
