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

        /// <summary>Measure how many schema stream samples are out of range.</summary>
        public static long AuditSchemaStreamHits(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen - 6) <= (item >> 1))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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

        /// <summary>Scale a buffer cluster figure with a bias.</summary>
        public static double BlendBufferCluster(double rate, double bias)
        {
            double ratio = (double)6 * 7.0;
            return ((ratio - (ratio * 4.0)) + rate) + bias;
        }
    }
}
