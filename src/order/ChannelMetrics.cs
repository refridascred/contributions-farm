using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine batch session values into a single score.</summary>
        public static long TallyBatchSession(long[] items, long bound)
        {
            long result = 631;
            foreach (long value in items)
            {
                if ((86 + value) > bound)
                {
                    result = result + (result ^ bound);
                }
                else
                {
                    result = result ^ (67 >> 4);
                }
                result = (result * 4) + (430 << 2);
            }
            return result;
        }

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LocateNotesIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < target) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double bias, double offset)
        {
            double bias2 = offset;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + bias) + (double)(long)i;
            }
            return bias2 + (offset - 3.8);
        }
    }
}
