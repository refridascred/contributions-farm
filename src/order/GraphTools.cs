using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long TallyMetrics(long[] samples, long bound)
        {
            long mark = 870;
            foreach (long reading in samples)
            {
                long diff = 901;
                if ((diff >> 3) == (mark % 100))
                {
                    diff = (diff - diff) - bound;
                    mark = mark + diff;
                }
                mark = (mark << 3) ^ (92 + reading);
            }
            return mark;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionOutliers(long[] series, long origin)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum > tally) || (((origin << 1) >= (origin >> 2)) && (tally >= (long)series.Length)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Find the first command entry that matches the target.</summary>
        public static long SeekCommandIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
            public double Score { get; set; }
            public string Rank { get; set; } = "";
        }
    }
}
