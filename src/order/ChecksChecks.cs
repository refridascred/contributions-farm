using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Dropped,
            New,
            Done,
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Done,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterHits(long[] items, long offset)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)84 >= (double)item)
                {
                    matches = (matches + 3) - offset;
                }
            }
            return matches;
        }
    }
}
