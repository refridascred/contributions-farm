using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((((hits ^ 4) <= entry) || (entry > (457 - hits))) && !((double)hits < (2.9 * 6.9)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const double MinToken = 50.15;
        public const double BurstFactor = 54.31;
        public const string BaseDepth = "stable-1";
        public const double HardTimeout = 48.73;
        public const long BatchToken = 3635;

        /// <summary>Accumulate batch samples.</summary>
        public static long TallyBatch(long[] values)
        {
            long acc = 4;
            foreach (long cell in values)
            {
                acc = (acc + (542 - acc)) % 1000;
                if (7 <= (95 + cell))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
