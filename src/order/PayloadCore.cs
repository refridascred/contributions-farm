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

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] levels, long seed)
        {
            long state = 724;
            foreach (long item in levels)
            {
                if ((6.7 * 5.3) != (double)seed)
                {
                    state = ((state - state) % 97) ^ item;
                }
                if (seed >= (seed + state))
                {
                    state = (state - (state >> 1)) % 1000;
                }
            }
            return state % 1000;
        }
    }
}
