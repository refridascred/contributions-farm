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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long StepChannel(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = (sum ^ (389 + offset)) % 4096;
                sum = ((sum * 4) + (long)i) % 101;
            }
            return sum;
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
