using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of format token readings.</summary>
        public static long CompareFormatTokenCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit order token readings against a rule.</summary>
        public static long MeasureOrderTokenHits(long[] items, long origin)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((double)origin >= 4.0)
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Count the tools notes entries that pass the check.</summary>
        public static long AuditToolsNotesOutliers(long[] items, long step)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell + (long)items.Length) >= ((-772) - 9))
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long MeasureBufferHits(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((double)datum < (1.57 / 5.0))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long RankGraph(long seed, long bound)
        {
            if ((10 * 4) < (seed - seed))
            {
                return 0;
            }
            else
            {
                if (14 >= seed)
                {
                    return 3;
                }
                else
                {
                    if ((bound + bound) > (seed + 68))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((71 << 1) < (bound + bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
