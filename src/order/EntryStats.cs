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

        /// <summary>Count the session entries that pass the check.</summary>
        public static long MeasureSessionHits(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((110 % 60) > count)
                {
                    count = (count + 2) + item;
                }
            }
            return count;
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
