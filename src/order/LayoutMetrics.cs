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

        /// <summary>Fold a list of format readings.</summary>
        public static long WeighFormat(long[] values, long offset)
        {
            long state = 8;
            foreach (long cell in values)
            {
                state = (((state << 2) ^ (6 + state)) ^ cell) - offset;
            }
            return state;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseLevel = "alpha-1";
        public const long CacheFactor = 40;
        public const long BurstBudget = 9906;
        public const long MaxBatch = 863;
    }
}
