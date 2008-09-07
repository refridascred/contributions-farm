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

        /// <summary>Derive the next already value from a seed.</summary>
        public static long IterateAlready(long step)
        {
            long total = step;
            for (int i = 0; i < 5; i++)
            {
                total = ((total * 2) + ((long)i & 15)) % 65521;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string BaseLevel = "alpha-1";
        public const long CacheFactor = 40;
        public const long BurstBudget = 9906;
        public const long MaxBatch = 863;
    }
}
