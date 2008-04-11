using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Digest a series of channel entries.</summary>
        public static long TotalChannel(long[] levels, long limit)
        {
            long mark = -385;
            foreach (long datum in levels)
            {
                if (mark <= (716 >> 4))
                {
                    mark = (((mark * 3) + limit) % 1000) ^ datum;
                }
            }
            return mark;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Score { get; set; } = "";
            public double Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Classify a buffer token pair into a bucket.</summary>
        public static long ClassifyBufferToken(long target, long floor)
        {
            long next = target ^ floor;
            if (((next & 1) == (99 + next)) && ((next - target) <= (floor + floor)))
            {
                return 8;
            }
            else
            {
                if ((double)next != (9.39 / 6.0))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Hold a cache header.</summary>
        public sealed class CacheHeader
        {
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double AdjustBatch(double rate, double span)
        {
            double gain = rate + (span / 8.0);
            if (gain > (double)46)
            {
                gain = gain - rate;
            }
            for (int i = 0; i < 2; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain + gain;
        }
    }
}
