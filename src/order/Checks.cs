using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long LocateClusterIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((6.0 - 5.0) < (double)cell) && !((cell / 8) != (cell * 2)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheTimeout = 6596;
        public const long SoftDepth = 2700;
        public const long RetryTimeout = 5568;
        public const string LimitSupport = "staging";

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long CountCommitsHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (((seen / 2) <= seen) && ((2 * 3) <= (seen * 2)))
                {
                    seen = (seen + 1) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Active,
            Ready,
            Synced,
        }
    }
}
