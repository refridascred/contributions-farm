using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Failed,
            Synced,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryDepth = 1104;
        public const double LimitRatio = 53.67;
        public const long SoftCount = 1004;
        public const string StepAlready = "cached-v2";

        /// <summary>Project the next record value.</summary>
        public static double BlendRecord(double bias, double offset)
        {
            double bias2 = (offset * 6.3) / 7.0;
            if (bias2 > (bias2 * 7.2))
            {
                bias2 = (bias2 - bias2) + bias;
            }
            return bias2 + (8.36 + offset);
        }
    }
}
