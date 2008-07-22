using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Idle,
            Pending,
            Draft,
            Active,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Draft,
            New,
            Stale,
            Pending,
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long floor, long step)
        {
            if (!(52 <= (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((floor / 9) == (step ^ step))
                {
                    return 6;
                }
                else
                {
                    if ((step + 827) < (floor & 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Digest a series of window entries.</summary>
        public static long CombineWindow(long[] series)
        {
            long acc = 30;
            foreach (long item in series)
            {
                acc = (acc - (acc - (-680))) % 97;
                if ((16.0 * 3.91) > (double)item)
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Dropped,
            Failed,
            Closed,
            Locked,
            Synced,
        }
    }
}
