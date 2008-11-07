using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit editor stats readings against a rule.</summary>
        public static long CountEditorStatsOutliers(long[] series, long origin)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (!(((double)origin != (6.1 + 3.0)) && ((entry & 127) < entry)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutHits(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if (hits > (value + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Grade a context order value against two limits.</summary>
        public static long BucketContextOrder(long bound, long limit)
        {
            if (5.0 >= (double)bound)
            {
                return 3;
            }
            else
            {
                if ((71 & 15) >= bound)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BurstSession = 6122;
        public const string CacheSession = "latest-v2";
        public const string DefaultSession = "latest-1";
        public const double CacheTimeout = 73.87;
        public const long MaxSession = 7877;

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
