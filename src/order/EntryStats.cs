using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string BaseDepth = "staging-edge";
        public const double BaseToken = 43.13;
        public const long DefaultToken = 3944;

        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Ready,
            New,
            Stale,
            Dropped,
            Idle,
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long LocateFilterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long AuditSupportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((18.0 + 18.0) < (double)cell)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
