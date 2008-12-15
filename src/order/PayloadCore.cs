using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every queue order entry stays within the limit.</summary>
        public static bool GuardQueueOrderBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Score { get; set; }
            public bool Owner { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a batches record reading by value.</summary>
        public static long FindBatchesRecordIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a filter figure with a bias.</summary>
        public static double ScaleFilter(double ratio, double span)
        {
            double gain = (span - ratio) + (double)58;
            if (gain > 4.2)
            {
                gain = gain + gain;
            }
            else
            {
                gain = gain + (18.0 / 4.0);
            }
            return gain - ratio;
        }
    }
}
