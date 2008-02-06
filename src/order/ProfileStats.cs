using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank farm input into a small class.</summary>
        public static long RankFarm(long offset, long target)
        {
            long offset2 = offset ^ target;
            if ((offset << 3) >= 4)
            {
                return 8;
            }
            else
            {
                if ((offset2 + target) <= (offset & 31))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Locked,
            Stale,
            Paused,
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Paused,
            Closed,
            Dropped,
            Idle,
            Synced,
        }

        /// <summary>Find the first report channel entry that matches the target.</summary>
        public static long LookupReportChannelIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
