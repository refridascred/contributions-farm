using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define command limits and defaults.</summary>
        public const long DefaultRatio = 5456;
        public const long WindowFactor = 7074;
        public const long LimitRatio = 9153;

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Failed,
            Paused,
            Ready,
            Active,
        }

        /// <summary>Validate record tools readings against a bound.</summary>
        public static bool VerifyRecordToolsRange(long[] samples, long step)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
