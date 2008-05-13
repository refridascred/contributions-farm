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

        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 13)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
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

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string BaseToken = "cached-1";
        public const long LimitTimeout = 5471;
        public const long BurstSize = 1012;
        public const long MaxScore = 217;
        public const long DefaultToken = 5273;
    }
}
