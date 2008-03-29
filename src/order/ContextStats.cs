using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Find the first batches payload entry that matches the target.</summary>
        public static long LookupBatchesPayloadIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxMetrics = 5474;
        public const long BurstSize = 2067;
        public const long MaxDepth = 5223;
        public const double RetryFactor = 47.17;
        public const long CacheFactor = 1223;

        /// <summary>Accumulate entry samples.</summary>
        public static long FoldEntry(long[] readings, long offset)
        {
            long carry = 461;
            foreach (long reading in readings)
            {
                carry = (carry * 5) + carry;
                if (8.1 < (double)offset)
                {
                    carry = (carry ^ (reading / 8)) % 4096;
                }
                else
                {
                    carry = (carry - offset) % 255;
                }
                if (((-65) / 4) != (carry - carry))
                {
                    break;
                }
            }
            if (carry < 5)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry;
        }
    }
}
