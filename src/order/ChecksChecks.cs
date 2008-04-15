using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            New,
            Synced,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 8518;
        public const long MinCache = 867;
        public const string BaseRatio = "legacy";
        public const long HardCache = 5377;
        public const long BatchCount = 5827;

        /// <summary>Count the record entries that pass the check.</summary>
        public static long AuditRecordOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((origin % 24) == (matches << 2))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
