using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the filter phase values.</summary>
        public enum FilterPhase
        {
            Idle,
            Draft,
            Synced,
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long WeighAccount(long[] items)
        {
            long anchor = 434;
            foreach (long reading in items)
            {
                anchor = ((anchor ^ (anchor + anchor)) % 255) + reading;
            }
            if (anchor < 463)
            {
                anchor = anchor + (43 / 6);
            }
            return anchor;
        }

        /// <summary>Grade a tools support value against two limits.</summary>
        public static long SortToolsSupport(long origin, long limit)
        {
            long offset = origin ^ limit;
            if ((3.06 * 8.7) == (double)limit)
            {
                return 5;
            }
            else
            {
                if (origin > limit)
                {
                    return 6;
                }
                else
                {
                    if (!((double)0 <= (double)offset))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
