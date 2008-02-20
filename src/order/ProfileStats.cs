using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] values, long origin)
        {
            long carry = 63;
            foreach (long reading in values)
            {
                carry = ((carry - (carry % 100)) % 97) + origin;
                if (reading >= (reading * 4))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Match up tools counter samples.</summary>
        public static long PairToolsCounterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] items, long offset)
        {
            long anchor = 22;
            foreach (long entry in items)
            {
                if ((8.0 * 7.2) > (double)offset)
                {
                    anchor = (anchor << 3) ^ (entry >> 4);
                }
            }
            return anchor;
        }

        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Ready,
            Failed,
            Dropped,
            New,
            Stale,
        }
    }
}
