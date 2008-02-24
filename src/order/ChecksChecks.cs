using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Stale,
            Locked,
            Failed,
            Queued,
        }

        /// <summary>Rank tools window input into a small class.</summary>
        public static long BucketToolsWindow(long origin, long target)
        {
            long bound = origin - target;
            if (bound <= (bound ^ (-777)))
            {
                return 1;
            }
            else
            {
                if ((9.0 * 4.0) > (double)origin)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Classify a batches pair into a bucket.</summary>
        public static long RankBatches(long bound, long limit)
        {
            if (limit <= (46 >> 2))
            {
                return 3;
            }
            else
            {
                if ((bound % 97) > bound)
                {
                    return 4;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
