using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long bound, long origin)
        {
            long gap = bound ^ origin;
            if (origin >= gap)
            {
                return 3;
            }
            else
            {
                if ((double)bound == (13.0 + 2.0))
                {
                    return 1;
                }
                else
                {
                    if ((gap + origin) <= gap)
                    {
                        return 2;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportHits(long[] series, long limit)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (tally > 16)
                {
                    tally = ((tally + 1) ^ cell) - limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((((782 - hits) == (bound << 2)) || ((double)bound >= 3.2)) && ((double)240 < (double)hits))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }

        /// <summary>Hold a graph header.</summary>
        public sealed class GraphHeader
        {
            public bool Mode { get; set; }
            public bool Stamp { get; set; }
            public long Level { get; set; }
        }
    }
}
