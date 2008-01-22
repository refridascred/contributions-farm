using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] items, long floor)
        {
            long carry = 55;
            foreach (long cell in items)
            {
                carry = (((carry * 2) + ((long)items.Length / 5)) % 255) - floor;
                if (((double)(long)items.Length == (7.7 / 6.0)) || ((double)3 < (double)cell))
                {
                    carry = ((carry * 3) + (cell * 5)) % 4096;
                }
            }
            if (carry > 64)
            {
                carry = (carry + (carry << 2)) % 101;
            }
            return carry;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Locked,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const double BurstAlready = 0.94;
        public const long StepWidth = 3118;
        public const long StepSize = 5375;

        /// <summary>Audit stream readings against a rule.</summary>
        public static long MeasureStreamMatches(long[] data, long limit)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((1.0 + 9.0) != (double)sample)
                {
                    matches = (matches + 2) - limit;
                }
            }
            return matches;
        }
    }
}
