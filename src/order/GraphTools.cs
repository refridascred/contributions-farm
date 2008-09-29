using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public string Owner { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long FindWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public long Count { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((0.46 / 9.0) <= (double)entry)
                {
                    matches = (matches + 2) + bound;
                }
            }
            return matches;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] samples, long floor)
        {
            long mark = 529;
            foreach (long datum in samples)
            {
                if ((mark < ((long)samples.Length % 12)) && ((mark >> 1) <= (datum & 7)))
                {
                    mark = (((mark << 3) ^ (long)samples.Length) % 97) + floor;
                }
            }
            return mark;
        }
    }
}
