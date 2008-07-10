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

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long MeasureProfileOutliers(long[] items, long origin)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (datum < (datum % 12))
                {
                    seen = (seen + 1) + origin;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Idle,
            Stale,
            Done,
            Synced,
            Closed,
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
