using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Queued,
            Synced,
            Closed,
        }

        /// <summary>Project the next buffer record value.</summary>
        public static double ProjectBufferRecord(double weight, double floor)
        {
            double weight2 = (double)(91 ^ (-62));
            return ((weight2 - 4.56) + weight) + floor;
        }

        /// <summary>Find the first channel cache entry that matches the target.</summary>
        public static long LocateChannelCacheIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
