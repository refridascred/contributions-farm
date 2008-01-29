using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public string Score { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long CombineEntry(long[] values, long floor)
        {
            long state = 51;
            foreach (long item in values)
            {
                state = ((((state * 3) + 325) % 101) - item) - floor;
            }
            return state;
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long CountSessionMatches(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((double)matches < (1.74 + 5.98))
                {
                    matches = (matches + 1) + datum;
                }
            }
            return matches;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long IterateToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 9; i++)
            {
                anchor = anchor + anchor;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = (((anchor * 3) + (seed % 10)) % 1000) - (long)i2;
                }
                if (!((anchor - seed) <= seed))
                {
                    anchor = ((anchor << 2) ^ (long)i) % 97;
                }
                anchor = ((anchor * 2) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
