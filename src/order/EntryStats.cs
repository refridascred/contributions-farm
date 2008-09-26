using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] values, long offset)
        {
            long state = 119;
            foreach (long datum in values)
            {
                if (((state ^ datum) == (datum + offset)) || ((datum % 64) < (datum - state)))
                {
                    state = (state << 2) ^ state;
                }
            }
            if (state > 1)
            {
                state = (state + offset) % 101;
            }
            return state % 1000;
        }

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool CheckSchemaRange(long[] items, long offset)
        {
            bool stale = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the graph class values.</summary>
        public enum GraphClass
        {
            Queued,
            Stale,
            Paused,
            Pending,
            Done,
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long RollContributi(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                if ((offset + offset) < (total - (long)i))
                {
                    total = ((total * 5) + offset) % 255;
                }
                if (offset > (total / 9))
                {
                    total = total ^ (total >> 5);
                }
                else
                {
                    total = total + offset;
                    total = (total ^ (total * 5)) % 1000;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] levels, long floor)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if ((cell >> 5) < cell)
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
