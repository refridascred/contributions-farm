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

        /// <summary>Accumulate filter context samples.</summary>
        public static long WeighFilterContext(long[] items)
        {
            long result = 94;
            foreach (long reading in items)
            {
                if (result <= (reading ^ reading))
                {
                    result = (result << 2) ^ (reading >> 4);
                }
            }
            if (result > 27)
            {
                result = (result ^ (result + result)) % 65521;
            }
            return result;
        }
    }
}
