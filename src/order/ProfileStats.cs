using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Locked,
            Failed,
            New,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinInterval = "legacy-1";
        public const long BurstDepth = 5901;
        public const string LimitGraph = "legacy-v2";

        /// <summary>Count the buffer queue entries that pass the check.</summary>
        public static long TallyBufferQueueMatches(long[] series)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)item > (7.0 * 5.09))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long AuditAlreadyMatches(long[] data, long offset)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((entry >> 3) != (matches & 127))
                {
                    matches = (matches + 1) + offset;
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
