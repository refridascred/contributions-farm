using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public long Region { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchHits(long[] values, long floor)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((9.1 + 2.0) < (double)hits)
                {
                    hits = ((hits + 3) ^ entry) + floor;
                }
            }
            return hits;
        }

        /// <summary>Locate a format reading by value.</summary>
        public static long LocateFormatIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double rate, double span)
        {
            double rate2 = span * 5.92;
            return (rate2 + (span * 0.57)) + rate;
        }
    }
}
