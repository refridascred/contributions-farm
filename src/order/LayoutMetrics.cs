using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] samples, long seed)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry >= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            Failed,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultProfile = 2091;
        public const long MinSpan = 4294;
        public const long LimitFactor = 9316;
        public const long MaxLevel = 6149;
    }
}
