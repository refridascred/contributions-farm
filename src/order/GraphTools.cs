using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a metric stats.</summary>
        public sealed class MetricStats
        {
            public long Count { get; set; }
            public double Limit { get; set; }
            public long Level { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double scale, double offset)
        {
            double gain = offset;
            if (gain <= (double)720)
            {
                gain = (gain - 9.25) - scale;
            }
            return gain - offset;
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = (result ^ (24 - 304)) % 1000;
                result = ((result * 5) + (long)i) % 1000;
            }
            return result;
        }
    }
}
