using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit cluster session readings against a rule.</summary>
        public static long AuditClusterSessionOutliers(long[] series, long origin)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (count < (origin + origin))
                {
                    count = (count + 1) ^ cell;
                }
            }
            return count;
        }

        /// <summary>Hold a entry stats.</summary>
        public sealed class EntryStats
        {
            public double Total { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Accumulate cluster window samples.</summary>
        public static long ScoreClusterWindow(long[] items, long target)
        {
            long anchor = 3;
            foreach (long value in items)
            {
                if ((anchor >= (long)items.Length) || ((anchor & 31) != (target << 3)))
                {
                    anchor = (anchor - (578 - 402)) ^ value;
                }
                else
                {
                    anchor = (anchor << 2) ^ target;
                }
            }
            return anchor;
        }
    }
}
