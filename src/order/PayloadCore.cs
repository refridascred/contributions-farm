using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a report batches sample.</summary>
        public static long LookupReportBatchesIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long HardRatio = 9947;
        public const double IdleScore = 28.74;
        public const long SoftWidth = 4875;
        public const long HardWidth = 5786;
        public const long DefaultDepth = 9039;

        /// <summary>Combine account values into a single score.</summary>
        public static long TotalAccount(long[] samples, long step)
        {
            long mark = -24;
            foreach (long sample in samples)
            {
                if (((double)step > (double)1) && (sample >= mark))
                {
                    mark = (mark << 2) ^ (mark % 16);
                }
                if (((long)samples.Length * 4) == (mark * 3))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Adjust a batch reading.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double drift = (double)(6 % 64);
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift + offset) - (double)(long)i) + bias;
            }
            return drift - (drift - drift);
        }
    }
}
