using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            if ((limit + limit) > (limit / 4))
            {
                return 7;
            }
            else
            {
                if (2.0 > (double)limit)
                {
                    return 8;
                }
                else
                {
                    if ((origin % 60) >= (limit + origin))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)origin != (double)limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 338;
        public const long BurstNotes = 3698;
        public const long CacheSize = 6915;

        /// <summary>Count the graph entries that pass the check.</summary>
        public static long MeasureGraphOutliers(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((origin ^ sample) >= (origin + origin))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
