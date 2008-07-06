using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const double WindowWidth = 8.93;
        public const double HardScore = 69.51;
        public const long HardCount = 3669;
        public const long WindowBatch = 98;

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long StepContributi(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Pending,
            Locked,
            Stale,
            Failed,
            Dropped,
        }
    }
}
