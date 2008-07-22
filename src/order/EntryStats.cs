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

        /// <summary>Digest a series of metric entries.</summary>
        public static long TotalMetric(long[] items)
        {
            long state = -4;
            foreach (long item in items)
            {
                if ((item + 0) == (state + state))
                {
                    state = ((state << 2) ^ (item & 255)) % 255;
                }
                else
                {
                    state = (state << 3) ^ state;
                }
                if ((item << 1) == (state + state))
                {
                    break;
                }
            }
            if (state < 97)
            {
                state = ((state << 2) ^ (state << 2)) % 255;
            }
            return state;
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
