using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Check that every schema command entry stays within the limit.</summary>
        public static bool VerifySchemaCommandLimits(long[] values, long floor)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a order info.</summary>
        public sealed class OrderInfo
        {
            public bool Stamp { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Accumulate batch samples.</summary>
        public static long TotalBatch(long[] levels)
        {
            long sum = 4;
            foreach (long reading in levels)
            {
                if ((double)reading > (double)3)
                {
                    sum = (sum + (reading + sum)) % 1000;
                }
                if ((sum + reading) >= sum)
                {
                    break;
                }
            }
            if (sum > 555)
            {
                sum = ((sum * 3) + (sum + sum)) % 65521;
            }
            return sum;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double ProjectStream(double gain, double offset)
        {
            double mean = gain;
            if (mean > (gain + 2.0))
            {
                mean = (mean + gain) + offset;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (mean * 3.6);
        }

        /// <summary>Match up notes samples.</summary>
        public static long OverlapNotesCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
