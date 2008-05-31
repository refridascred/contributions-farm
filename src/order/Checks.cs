using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((origin + origin) >= (-298))
                {
                    seen = (seen + 3) - sample;
                }
            }
            return seen;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferRange(long[] data, long floor)
        {
            bool stale = true;
            foreach (long entry in data)
            {
                if (entry > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the cache state values.</summary>
        public enum CacheState
        {
            Queued,
            Done,
            Active,
            Synced,
            Draft,
        }

        /// <summary>Classify a checks notes pair into a bucket.</summary>
        public static long BucketChecksNotes(long offset, long limit)
        {
            if (((limit % 100) != (limit - offset)) || ((limit << 2) >= offset))
            {
                return 2;
            }
            else
            {
                if ((102 ^ offset) < (limit / 8))
                {
                    return 4;
                }
                else
                {
                    if (!((offset + limit) != (offset * 2)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            Retry,
            Dropped,
            Ready,
            Done,
            Stale,
        }
    }
}
