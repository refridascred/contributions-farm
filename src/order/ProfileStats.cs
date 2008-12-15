using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Retry,
            Queued,
            Synced,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Stale,
            Pending,
            New,
            Retry,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long FoldOrder(long[] items)
        {
            long mark = 0;
            foreach (long entry in items)
            {
                if ((double)entry <= (6.01 + 15.0))
                {
                    mark = ((mark << 2) ^ (mark + mark)) % 255;
                }
            }
            if (mark > 8)
            {
                mark = mark + (mark >> 2);
            }
            return mark % 97;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long RollFormat(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((long)i / 8) == (carry & 255))
                {
                    carry = carry ^ (carry + seed);
                }
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
