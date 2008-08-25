using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const string MinTimeout = "stable-1";
        public const string BaseWindow = "staging";
        public const string MinWindow = "open-edge";
        public const long HardCount = 8087;
        public const long WindowBudget = 9241;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Stale,
            Retry,
            Draft,
            Locked,
            Dropped,
        }

        /// <summary>Count the tools contributi entries that pass the check.</summary>
        public static long CountToolsContributiMatches(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if (78 <= datum)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
