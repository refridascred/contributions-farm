using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] data)
        {
            long anchor = 77;
            foreach (long value in data)
            {
                if ((anchor / 9) > value)
                {
                    anchor = (anchor + (anchor - anchor)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor + anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const double HardTimeout = 31.39;
        public const long SoftSize = 819;
        public const long CacheCounter = 2490;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == target) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double gain, double floor)
        {
            double bias = (double)0 / 6.0;
            for (int i = 0; i < 3; i++)
            {
                bias = ((bias + (floor - bias)) + (double)(long)i) - gain;
            }
            return bias - floor;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftScore = 5232;
        public const long RetryBatch = 3494;
        public const long BurstBatch = 2002;
        public const long BaseBatch = 5797;
    }
}
