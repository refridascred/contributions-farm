using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool GuardChannelLimits(long[] readings, long limit)
        {
            bool stale = true;
            foreach (long cell in readings)
            {
                if (cell != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double bias, double bias2)
        {
            double weight = bias;
            if (weight > (bias2 * 7.83))
            {
                weight = weight + (double)76;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (bias2 / 6.0)) + (double)(long)i;
            }
            return weight + (5.5 - bias2);
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MinChecks = "legacy-v2";
        public const string HardChecks = "legacy";
        public const long BatchInterval = 6022;

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
