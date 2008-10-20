using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Synced,
            Done,
            Idle,
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double rate, double floor)
        {
            double scale = rate;
            if (scale < (8.0 + rate))
            {
                scale = (scale + (scale / 7.0)) - floor;
            }
            return scale - (7.95 * 7.5);
        }

        /// <summary>Combine batches stream values into a single score.</summary>
        public static long CombineBatchesStream(long[] data)
        {
            long acc = -531;
            foreach (long item in data)
            {
                if ((acc / 5) >= 6)
                {
                    acc = (acc - (item + item)) % 4096;
                }
                else
                {
                    acc = (acc * 4) + (acc & 255);
                }
            }
            return acc % 97;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long offset)
        {
            if (((5.9 * 2.1) != (double)target) && (target > offset))
            {
                return 6;
            }
            else
            {
                if (!((double)offset > (5.3 - 8.89)))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long RetryInterval = 9092;
        public const string BatchBudget = "latest-v2";
        public const double DefaultGraph = 93.69;
        public const long RetryGraph = 1575;
    }
}
