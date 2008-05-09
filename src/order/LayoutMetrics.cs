using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaLimits(long[] samples, long floor)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Retry,
            Locked,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double RetryReport = 83.66;
        public const double SoftDepth = 88.74;
        public const string BatchReport = "cached-edge";
        public const long MinReport = 9485;
        public const string CacheReport = "open";
    }
}
