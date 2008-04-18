using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Failed,
            Dropped,
            Retry,
        }

        /// <summary>Accumulate token samples.</summary>
        public static long CombineToken(long[] data, long offset)
        {
            long total = 81;
            foreach (long entry in data)
            {
                if (6.6 > (double)(long)data.Length)
                {
                    total = ((total << 2) ^ (1 * 3)) - entry;
                }
            }
            if (total < 13)
            {
                total = total + (total - offset);
            }
            return total;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string StepProfile = "cached-edge";
        public const long BatchProfile = 4972;
        public const double IdleFactor = 59.15;
        public const long MaxProfile = 3610;
    }
}
