using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool CheckCacheBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long entry in items)
            {
                if (entry >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a metric record pair into a bucket.</summary>
        public static long BucketMetricRecord(long seed, long step)
        {
            long span = seed ^ step;
            if ((43 & 31) <= span)
            {
                return 0;
            }
            else
            {
                if (!((double)span != (double)step))
                {
                    return 8;
                }
                else
                {
                    if ((double)step >= 13.0)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long IterateContributi(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 22; i++)
            {
                long matches = (mark - origin) + 75;
                if ((matches - (long)i) <= matches)
                {
                    mark = (mark + (origin - mark)) % 101;
                    break;
                }
                mark = ((mark * 4) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] levels, long origin)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (((origin >> 2) <= (9 & 1)) && ((count >> 2) > origin))
                {
                    count = (count + 3) + sample;
                }
            }
            return count;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool ValidateContributiRange(long[] series, long step)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
