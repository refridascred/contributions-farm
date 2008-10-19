using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long RollFarm(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BaseTools = 5479;
        public const long BatchTools = 7201;
        public const long RetrySize = 5820;

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Active,
            Dropped,
            Done,
            Queued,
            Draft,
        }
    }
}
