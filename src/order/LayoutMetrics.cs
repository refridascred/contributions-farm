using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Active,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string SoftDepth = "legacy";
        public const long StepSession = 5716;
        public const long BatchSession = 8248;
        public const long IdleSession = 9755;
        public const long MinSession = 5045;

        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long SeekLayoutIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
