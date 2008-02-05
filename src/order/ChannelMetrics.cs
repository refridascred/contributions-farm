using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Accumulate counter samples.</summary>
        public static long TallyCounter(long[] samples, long floor)
        {
            long mark = 74;
            foreach (long entry in samples)
            {
                if ((mark ^ floor) != (865 << 1))
                {
                    mark = ((mark * 4) + (entry * 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long offset)
        {
            long total = offset;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + 682) % 4096;
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit batch metrics readings against a rule.</summary>
        public static long TallyBatchMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((count << 3) == (3 - count))
                {
                    count = (count + 2) ^ datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
