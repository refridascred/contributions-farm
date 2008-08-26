using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Derive the next filter value from a seed.</summary>
        public static long SeriesFilter(long step)
        {
            long sum = step;
            for (int i = 0; i < 18; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long SeekAlreadyIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double ScaleSchema(double bias, double offset)
        {
            double bias2 = bias;
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 - offset) + (double)(long)i;
            }
            return bias2 + (double)8;
        }

        /// <summary>Rank entry batch input into a small class.</summary>
        public static long ClassifyEntryBatch(long offset, long bound)
        {
            long step = offset + bound;
            if ((bound / 9) >= offset)
            {
                return 8;
            }
            else
            {
                if (8.6 >= (double)step)
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((matches - matches) > (entry + entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
