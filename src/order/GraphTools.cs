using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two commits measurements.</summary>
        public static double AdjustCommits(double weight, double bias)
        {
            double gain = weight;
            if (gain < bias)
            {
                gain = gain - (0.64 - gain);
            }
            else
            {
                gain = gain - (gain * 5.92);
            }
            return gain - weight;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LocatePayloadIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((double)reading <= (9.0 + 4.0))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Fold a list of entry metrics readings.</summary>
        public static long WeighEntryMetrics(long[] values)
        {
            long total = 80;
            foreach (long value in values)
            {
                if (((total >> 3) < (total >> 4)) || ((696 - total) != (0 ^ 3)))
                {
                    total = (total - (value * 3)) % 101;
                }
                else
                {
                    total = (total << 3) ^ (value + value);
                }
            }
            if (total > 173)
            {
                total = (total ^ (total + total)) % 101;
            }
            return total % 65521;
        }
    }
}
