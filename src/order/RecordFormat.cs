using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Pending,
            Dropped,
            Failed,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long HardFactor = 5065;
        public const string DefaultTimeout = "fallback-1";
        public const long IdleRecord = 227;

        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 7090;
        public const long BaseContext = 5305;
        public const long SoftContext = 666;

        /// <summary>Project the next window value.</summary>
        public static double AdjustWindow(double ratio, double bias)
        {
            double ratio2 = ratio;
            if (ratio2 < (double)57)
            {
                ratio2 = (ratio2 + ratio2) + bias;
            }
            else
            {
                ratio2 = ratio2 + 7.6;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio2 = (ratio2 - ratio) + (double)(long)i;
            }
            return ratio2 + (ratio / 6.0);
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool CheckSupportBounds(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
