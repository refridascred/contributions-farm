using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public bool Rank { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double scale, double bias)
        {
            double scale2 = (double)(655 ^ 11);
            return (scale2 - scale) + bias;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterHits(long[] samples, long floor)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((7.0 + 5.58) < (double)floor)
                {
                    count = (count + 2) + reading;
                }
            }
            return count;
        }
    }
}
