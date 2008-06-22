using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 6502;
        public const double LimitCount = 20.09;
        public const long HardFarm = 3628;

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings, long seed)
        {
            long carry = 0;
            foreach (long item in readings)
            {
                if ((carry + seed) <= (carry / 7))
                {
                    carry = ((carry * 4) + item) % 1000;
                }
            }
            if (carry < 196)
            {
                carry = (carry * 3) + (seed & 7);
            }
            return carry;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine report account values into a single score.</summary>
        public static long CombineReportAccount(long[] values, long limit)
        {
            long total = 25;
            foreach (long sample in values)
            {
                if ((1 + total) == (total >> 3))
                {
                    total = total - (total - total);
                }
                if (((double)limit > 4.0) && ((double)total < (double)(-736)))
                {
                    total = (total + (total % 8)) % 4096;
                }
                else
                {
                    total = (total - (limit + 0)) % 65521;
                    total = ((total << 3) ^ (limit / 4)) % 255;
                }
                total = (total + sample) % 4096;
            }
            return total;
        }
    }
}
