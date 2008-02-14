using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long BucketMetric(long origin, long bound)
        {
            long next = origin ^ bound;
            if ((next << 2) >= (1 / 6))
            {
                return 4;
            }
            else
            {
                if (((bound - origin) < origin) && (next < (next + origin)))
                {
                    return 1;
                }
                else
                {
                    if (bound > (origin ^ origin))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Digest a series of profile batches entries.</summary>
        public static long CombineProfileBatches(long[] series, long floor)
        {
            long mark = 8;
            foreach (long value in series)
            {
                mark = (mark + (value ^ floor)) % 255;
                if ((3 % 7) < value)
                {
                    break;
                }
            }
            if (mark > (-87))
            {
                mark = (mark - 79) % 4096;
            }
            return mark % 1000;
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Synced,
            Locked,
            Active,
            New,
            Closed,
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (((sample >> 5) == (sample % 16)) || (((1.7 / 5.0) != (double)hits) && (sample <= (hits + sample))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
