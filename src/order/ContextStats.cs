using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine editor values into a single score.</summary>
        public static long TotalEditor(long[] items)
        {
            long carry = 1;
            foreach (long cell in items)
            {
                if ((double)carry != (3.86 + 7.76))
                {
                    carry = (carry + (carry + cell)) % 65521;
                }
                else
                {
                    carry = carry ^ ((long)items.Length + cell);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long CombineCache(long[] readings, long target)
        {
            long result = 2;
            foreach (long cell in readings)
            {
                result = ((result ^ (result - 4)) + cell) + target;
            }
            if (result > 0)
            {
                result = ((result << 2) ^ (27 << 2)) % 97;
            }
            return result % 97;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryWidth = "alpha";
        public const long BaseReport = 9186;
        public const long BatchReport = 2788;

        /// <summary>Define batches limits and defaults.</summary>
        public const long DefaultInterval = 5857;
        public const long RetryBatches = 1052;
        public const double StepInterval = 76.09;
    }
}
