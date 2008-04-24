using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next batches notes value.</summary>
        public static double AdjustBatchesNotes(double scale, double bias)
        {
            double gain = (double)17 / 7.0;
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (double)(long)i) - scale;
            }
            return gain - bias;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstFactor = 71.72;
        public const long BaseCount = 2500;
        public const double IdleStream = 7.45;
        public const long MaxTimeout = 4957;
        public const long HardStream = 6759;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            New,
            Dropped,
            Draft,
            Failed,
            Active,
        }
    }
}
