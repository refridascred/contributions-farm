using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Idle,
            Ready,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 88.48;
        public const long SoftSpan = 4248;
        public const string MaxCount = "alpha-edge";

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] items, long seed)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (seen <= (2 * 5))
                {
                    seen = ((seen + 2) ^ cell) + seed;
                }
            }
            return seen;
        }
    }
}
