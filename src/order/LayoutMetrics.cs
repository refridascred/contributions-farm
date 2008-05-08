using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first session entry that matches the target.</summary>
        public static long LocateSessionIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Ready,
            Paused,
            Active,
            Queued,
            Pending,
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double RetryChannel = 55.08;
        public const string IdleChannel = "staging-v2";
        public const double CacheTimeout = 77.7;
        public const double RetryLevel = 31.2;
        public const double StepChannel = 49.19;
    }
}
