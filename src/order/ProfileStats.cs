using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const double HardSpan = 18.58;
        public const long SoftLevel = 312;
        public const long LimitGraph = 1305;

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesRange(long[] readings, long bound)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long HardSchema = 3304;
        public const long RetrySchema = 9998;
        public const long IdleSize = 8917;
        public const double MinDepth = 36.21;
        public const long IdleSchema = 1180;

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Ready,
            Queued,
            Dropped,
            Closed,
        }
    }
}
