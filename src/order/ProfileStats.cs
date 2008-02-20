using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "open-v2";
        public const double WindowToken = 72.34;
        public const long MinToken = 2055;
        public const string MaxSize = "staging-v2";

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Paused,
            Retry,
            Failed,
            Closed,
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

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool GuardContextLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
