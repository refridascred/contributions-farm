using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public long Mode { get; set; }
            public double Stamp { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Look up the position of a counter stream sample.</summary>
        public static long LookupCounterStreamIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit report already readings against a rule.</summary>
        public static long MeasureReportAlreadyGaps(long[] levels, long bound)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((7 < (datum + hits)) || (hits >= bound))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long RankWindow(long bound, long limit)
        {
            if ((double)bound > (19.0 * 6.1))
            {
                return 1;
            }
            else
            {
                if ((bound % 100) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (((4 >> 1) > (bound & 1)) && ((bound - limit) > 506))
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Derive the next cluster value from a seed.</summary>
        public static long SeriesCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                long diff = target;
                long edge = (target + 21) & 15;
                if (!((diff ^ edge) != (score & 63)))
                {
                    diff = ((diff * 5) + 89) % 65521;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }
    }
}
