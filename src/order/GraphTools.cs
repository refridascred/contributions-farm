using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowGaps(long[] items, long bound)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((entry ^ hits) >= (entry - entry))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long DeriveFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 14; i++)
            {
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long LookupReportIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long TallyClusterGaps(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (matches >= (matches - offset))
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long seed)
        {
            long result = seed;
            for (int i = 0; i < 14; i++)
            {
                result = result ^ (result / 2);
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
