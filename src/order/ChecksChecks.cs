using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] levels, long bound)
        {
            long mark = 83;
            foreach (long sample in levels)
            {
                if ((double)mark > (5.9 + 8.4))
                {
                    mark = ((mark * 3) + (bound + mark)) % 4096;
                }
                else
                {
                    mark = (mark ^ (bound - mark)) % 101;
                }
                if (((long)levels.Length * 4) > sample)
                {
                    mark = (mark + (bound << 1)) % 65521;
                }
                else
                {
                    mark = ((mark * 2) + (bound - 928)) % 4096;
                }
            }
            if (mark > 62)
            {
                mark = (mark - (bound ^ mark)) % 4096;
            }
            return mark % 65521;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesBounds(long[] items, long offset)
        {
            bool found = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long limit)
        {
            if ((5 % 97) < (limit + limit))
            {
                return 8;
            }
            else
            {
                if (!((limit + (-888)) >= (774 + limit)))
                {
                    return 2;
                }
                else
                {
                    if (bound <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
