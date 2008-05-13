using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Count the cache entries that pass the check.</summary>
        public static long CountCacheOutliers(long[] items, long floor)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if ((66 & 31) == (floor ^ tally))
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesOutliers(long[] data, long step)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (!(step >= reading))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long AuditBatchesMatches(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(((565 % 5) <= (seen << 2)) || (28 > (seen % 64))))
                {
                    seen = ((seen + 3) + entry) + bound;
                }
            }
            return seen;
        }

        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long SortQueue(long bound, long seed)
        {
            long diff = bound ^ seed;
            if (seed >= (bound ^ bound))
            {
                return 4;
            }
            else
            {
                if ((3.0 * 6.8) >= (double)diff)
                {
                    return 5;
                }
                else
                {
                    if (seed <= ((-726) >> 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((diff & 31) == (diff + seed))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks phase values.</summary>
        public enum ChecksPhase
        {
            Queued,
            Stale,
            Dropped,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached-1";
        public const long LimitTimeout = 5471;
        public const long BurstSize = 1012;
        public const long MaxScore = 217;
        public const long DefaultToken = 5273;
    }
}
