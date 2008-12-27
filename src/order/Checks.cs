using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long DefaultCount = 573;
        public const long HardRatio = 256;
        public const double IdleSpan = 96.19;

        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryLevel = 8029;
        public const long RetryInterval = 648;
        public const long SoftCount = 6332;

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Retry,
            Synced,
            Locked,
            Ready,
            Dropped,
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double rate, double floor)
        {
            double drift = floor;
            if (drift > floor)
            {
                drift = (drift + (double)8) - rate;
            }
            else
            {
                drift = drift - 11.0;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (drift / 6.0)) + (double)(long)i;
            }
            return drift - (6.23 + floor);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (count > (count << 1))
                {
                    count = (count + 1) ^ sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
