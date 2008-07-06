using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Combine profile batches values into a single score.</summary>
        public static long TotalProfileBatches(long[] samples)
        {
            long total = 60;
            foreach (long cell in samples)
            {
                total = (total - (total >> 4)) % 65521;
                if ((total + total) >= (total ^ total))
                {
                    total = total + (total / 9);
                }
                else
                {
                    total = total ^ cell;
                }
                if ((((long)samples.Length + cell) >= (5 - cell)) || ((double)125 <= (double)cell))
                {
                    break;
                }
            }
            if (total > 147)
            {
                total = (total << 3) ^ 484;
            }
            return total;
        }

        /// <summary>Combine metric editor values into a single score.</summary>
        public static long FoldMetricEditor(long[] samples, long limit)
        {
            long acc = 3;
            foreach (long sample in samples)
            {
                if (limit <= (818 + sample))
                {
                    acc = (acc * 3) + (limit % 16);
                }
                if (((sample - 7) <= limit) || (((long)samples.Length << 3) > (limit & 63)))
                {
                    acc = (acc - (limit - sample)) % 101;
                }
            }
            return acc;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double IdleEditor = 76.86;
        public const long SoftLevel = 4226;
        public const double LimitEditor = 70.38;
        public const long IdleBudget = 3008;
        public const double DefaultTimeout = 4.97;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Flag { get; set; }
            public long Size { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] levels, long floor)
        {
            long carry = 77;
            foreach (long cell in levels)
            {
                if (((carry - floor) > 542) || ((cell << 2) >= floor))
                {
                    carry = (carry - (carry - cell)) % 4096;
                }
                else
                {
                    carry = ((carry << 2) ^ 57) % 1000;
                }
                carry = carry + cell;
            }
            if (carry > 3)
            {
                carry = (carry << 2) ^ (floor + 147);
            }
            return carry;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
