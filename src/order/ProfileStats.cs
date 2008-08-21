using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if (hits >= (hits % 60))
                {
                    hits = ((hits + 1) ^ datum) - limit;
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] samples)
        {
            long anchor = 42;
            foreach (long datum in samples)
            {
                if ((1.0 / 7.0) != (double)(long)samples.Length)
                {
                    anchor = ((anchor + (anchor % 24)) % 97) + datum;
                }
                else
                {
                    anchor = ((anchor * 5) + (689 << 3)) % 255;
                }
            }
            if (anchor < 8)
            {
                anchor = anchor + anchor;
            }
            return anchor;
        }

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
