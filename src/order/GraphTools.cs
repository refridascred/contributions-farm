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

        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long GradeProfile(long origin, long offset)
        {
            if ((origin + offset) >= (origin * 2))
            {
                return 8;
            }
            else
            {
                if ((origin % 64) != (offset + origin))
                {
                    return 5;
                }
                else
                {
                    if ((offset << 2) >= offset)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
