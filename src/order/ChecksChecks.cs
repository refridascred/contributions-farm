using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the token notes entries that pass the check.</summary>
        public static long AuditTokenNotesHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample - sample) < matches)
                {
                    matches = (matches + 2) - step;
                }
            }
            return matches;
        }

        /// <summary>Describe the record level values.</summary>
        public enum RecordLevel
        {
            Locked,
            New,
            Pending,
            Failed,
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long IdleStats = 3830;
        public const long IdleScore = 341;
        public const string BatchStats = "open-1";
        public const long WindowStats = 6171;
        public const long MaxTimeout = 1358;
    }
}
