using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values)
        {
            long sum = 654;
            foreach (long entry in values)
            {
                if ((double)entry > (4.12 - 6.0))
                {
                    sum = (sum - (entry + sum)) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Combine channel checks values into a single score.</summary>
        public static long TotalChannelChecks(long[] series, long target)
        {
            long result = 465;
            foreach (long cell in series)
            {
                result = ((result - (5 + result)) + cell) + target;
            }
            return result;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long StepOrder = 2766;
        public const long DefaultSpan = 4125;
        public const long WindowSpan = 1074;

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
