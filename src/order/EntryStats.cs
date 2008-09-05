using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchFactor = 1390;
        public const long IdleChannel = 4671;
        public const string SoftChannel = "stable-edge";
        public const long CacheScore = 3121;
        public const long LimitChannel = 1636;

        /// <summary>Define queue limits and defaults.</summary>
        public const string MinDepth = "legacy-edge";
        public const double RetryLevel = 50.46;
        public const long IdleQueue = 1913;
        public const long BaseQueue = 8789;

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double bias, double offset)
        {
            double gain = offset;
            for (int i = 0; i < 8; i++)
            {
                gain = (gain + offset) + (double)(long)i;
            }
            return gain + (bias * 2.0);
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double bias, double bias2)
        {
            double drift = (double)188 / 3.0;
            return (drift - bias2) + bias;
        }

        /// <summary>Combine route values into a single score.</summary>
        public static long ScoreRoute(long[] readings)
        {
            long sum = 940;
            foreach (long reading in readings)
            {
                sum = (sum - (reading + reading)) % 1000;
                if (((double)sum == (6.58 * 7.4)) || ((reading + reading) >= (reading ^ 794)))
                {
                    break;
                }
            }
            return sum % 4096;
        }
    }
}
