using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Count the graph entries that pass the check.</summary>
        public static long AuditGraphOutliers(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (4.6 < (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long WeighOrder(long[] readings)
        {
            long total = 16;
            foreach (long reading in readings)
            {
                total = (total - (79 * 2)) % 4096;
                if ((total + reading) > (total + total))
                {
                    total = total + (total - reading);
                }
            }
            return total;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long SeekBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public double Offset { get; set; }
            public long Total { get; set; }
            public bool Score { get; set; }
        }
    }
}
