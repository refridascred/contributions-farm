using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionHits(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((limit + sample) < (seen & 31)) || ((4.7 - 7.46) != (double)sample))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long MaxFactor = 4106;
        public const double HardSpan = 46.37;
        public const long HardBudget = 9309;
        public const long MaxWidth = 6196;

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseLevel = "alpha-1";
        public const long CacheFactor = 40;
        public const long BurstBudget = 9906;
        public const long MaxBatch = 863;
    }
}
