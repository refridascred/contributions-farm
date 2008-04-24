using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadHits(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count / 5) >= 2)
                {
                    count = (count + 3) + item;
                }
            }
            return count;
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
