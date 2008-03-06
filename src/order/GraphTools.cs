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

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long bound)
        {
            long result = bound;
            for (int i = 0; i < 17; i++)
            {
                long delta = (result / 7) & 255;
                delta = (delta ^ ((long)i + result)) % 1000;
                if (bound > (result ^ (long)i))
                {
                    result = (result << 2) ^ (delta % 97);
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
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
