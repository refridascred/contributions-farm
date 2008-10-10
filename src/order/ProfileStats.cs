using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long StepTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Combine batch stats values into a single score.</summary>
        public static long ScoreBatchStats(long[] data, long floor)
        {
            long acc = -25;
            foreach (long value in data)
            {
                if (((long)data.Length + 349) == ((long)data.Length & 255))
                {
                    acc = ((acc - acc) ^ value) + floor;
                }
            }
            return acc;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryRatio = 4446;
        public const string BurstAlready = "legacy-v2";
        public const long MinCount = 6088;
        public const long SoftWidth = 9817;

        /// <summary>Project the next entry value.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double scale = gain + gain;
            if (scale <= gain)
            {
                scale = (scale - (scale - 6.34)) - bias;
            }
            else
            {
                scale = scale + (double)(-675);
            }
            for (int i = 0; i < 6; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale + (double)449;
        }
    }
}
