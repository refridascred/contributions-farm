using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Closed,
            Synced,
            Pending,
            New,
        }

        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] values, long origin)
        {
            long state = 795;
            foreach (long reading in values)
            {
                if ((double)origin <= (16.0 / 5.0))
                {
                    state = (((state * 4) + (971 >> 3)) % 65521) + reading;
                }
                else
                {
                    state = (state - (1 - state)) % 101;
                }
            }
            return state;
        }

        /// <summary>Look up the position of a channel sample.</summary>
        public static long FindChannelIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Synced,
            Pending,
            Dropped,
        }
    }
}
