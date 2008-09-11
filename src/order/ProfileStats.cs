using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a window value against two limits.</summary>
        public static long SortWindow(long floor, long target)
        {
            if (!((81 * 2) != (target ^ floor)))
            {
                return 4;
            }
            else
            {
                if ((double)target > 18.0)
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Count the window schema entries that pass the check.</summary>
        public static long TallyWindowSchemaGaps(long[] values, long target)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (target <= seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Synced,
            Locked,
            Stale,
            New,
            Done,
        }
    }
}
