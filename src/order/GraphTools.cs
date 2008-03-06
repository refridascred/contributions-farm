using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Iterate the farm graph series from a seed.</summary>
        public static long SeriesFarmGraph(long target)
        {
            long result = target;
            for (int i = 0; i < 9; i++)
            {
                result = result + result;
                if ((619 * 3) > result)
                {
                    continue;
                }
                result = (result + ((long)i - result)) % 101;
                result = ((result * 5) + (long)i) % 101;
            }
            return result;
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

        /// <summary>Adjust a record reading.</summary>
        public static double SmoothRecord(double scale, double span)
        {
            double rate = (double)(499 >> 3);
            for (int i = 0; i < 8; i++)
            {
                rate = ((rate - (rate * 8.56)) + (double)(long)i) - span;
            }
            return rate - (scale + scale);
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
