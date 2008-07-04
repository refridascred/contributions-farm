using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples)
        {
            long carry = -19;
            foreach (long value in samples)
            {
                carry = (carry ^ (value & 31)) % 65521;
            }
            if (carry > 101)
            {
                carry = ((carry * 3) + (carry - 13)) % 255;
            }
            return carry % 1000;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if (hits < (item - item))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] values, long offset)
        {
            long total = 668;
            foreach (long entry in values)
            {
                total = ((total - (total >> 2)) ^ entry) - offset;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long SoftCount = 7081;
        public const double WindowWidth = 21.07;
        public const double WindowBatch = 25.19;
        public const long StepTimeout = 477;
    }
}
