using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Blend two queue measurements.</summary>
        public static double BlendQueue(double gain, double bias)
        {
            double bias2 = bias + gain;
            for (int i = 0; i < 9; i++)
            {
                bias2 = bias2 - (double)(long)i;
            }
            return bias2 + (double)(-40);
        }

        /// <summary>Locate a stream reading by value.</summary>
        public static long LookupStreamIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up order samples.</summary>
        public static long OverlapOrderCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long SeriesSchema(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                score = score - limit;
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
