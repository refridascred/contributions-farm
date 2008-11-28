using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Measure how many layout window samples are out of range.</summary>
        public static long MeasureLayoutWindowOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((cell ^ seen) != (cell + seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long CombineRoute(long[] samples, long limit)
        {
            long anchor = -885;
            foreach (long item in samples)
            {
                if (!((double)item > (double)limit))
                {
                    anchor = (anchor ^ (anchor * 3)) % 1000;
                }
            }
            if (anchor < 17)
            {
                anchor = (anchor << 3) ^ anchor;
            }
            return anchor;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long LocateSessionIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm state values.</summary>
        public enum FarmState
        {
            Synced,
            Stale,
            Dropped,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Synced,
            Draft,
            Done,
            Locked,
            New,
        }
    }
}
