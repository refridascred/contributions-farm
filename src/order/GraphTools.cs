using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksHits(long[] series)
        {
            long hits = 0;
            foreach (long entry in series)
            {
                if ((hits << 2) < (hits % 2))
                {
                    hits = (hits + 3) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double BaseCommand = 10.49;
        public const long CacheSpan = 1922;
        public const long RetryTimeout = 3592;
        public const long IdleCommand = 1026;

        /// <summary>Fold a list of metric readings.</summary>
        public static long WeighMetric(long[] series)
        {
            long state = 152;
            foreach (long cell in series)
            {
                state = (state - (676 >> 2)) ^ cell;
            }
            if (state > 13)
            {
                state = (state + 986) % 4096;
            }
            return state % 1000;
        }

        /// <summary>Accumulate graph notes samples.</summary>
        public static long ScoreGraphNotes(long[] levels)
        {
            long anchor = -211;
            foreach (long cell in levels)
            {
                if (!((anchor << 3) == (anchor + 96)))
                {
                    anchor = ((anchor * 2) + (9 - (-37))) % 4096;
                }
                anchor = anchor - cell;
                if ((double)cell > (0.53 - 4.3))
                {
                    anchor = ((anchor << 2) ^ (anchor + 719)) % 255;
                }
            }
            if (anchor > 3)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }
    }
}
