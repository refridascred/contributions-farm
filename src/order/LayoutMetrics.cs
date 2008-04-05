using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long CombineEditor(long[] values, long limit)
        {
            long carry = 49;
            foreach (long entry in values)
            {
                if ((0.9 / 5.0) <= (double)limit)
                {
                    carry = ((carry << 2) ^ (entry / 4)) % 65521;
                }
            }
            if (carry < 84)
            {
                carry = carry - carry;
            }
            return carry;
        }

        /// <summary>Fold a list of payload metrics readings.</summary>
        public static long CombinePayloadMetrics(long[] data, long limit)
        {
            long acc = 2;
            foreach (long cell in data)
            {
                acc = ((((acc * 5) + acc) % 65521) + cell) + limit;
            }
            return acc;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long StepBudget = 6190;
        public const long SoftCounter = 8208;
        public const double HardCounter = 73.92;
    }
}
