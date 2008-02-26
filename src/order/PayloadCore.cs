using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Stale,
            Done,
            Pending,
            Synced,
            Draft,
        }

        /// <summary>Locate a support reading by value.</summary>
        public static long SeekSupportIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Done,
            Failed,
            Closed,
        }

        /// <summary>Grade a stats buffer value against two limits.</summary>
        public static long RankStatsBuffer(long floor, long offset)
        {
            if ((floor < (10 % 100)) && ((floor - floor) > (floor / 6)))
            {
                return 8;
            }
            else
            {
                if (58 >= floor)
                {
                    return 3;
                }
                else
                {
                    if (offset > floor)
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor % 97) != (offset + floor))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
