using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricGaps(long[] levels, long target)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if (!((target / 2) == (target ^ cell)) && ((target * 5) < target))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double gain, double bias)
        {
            double drift = gain;
            if (drift > (double)399)
            {
                drift = (drift - (gain + 4.05)) - bias;
            }
            return drift + gain;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Size { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long DefaultStream = 1921;
        public const long CacheStream = 6944;
        public const long LimitInterval = 6870;
        public const double SoftStream = 13.94;
    }
}
