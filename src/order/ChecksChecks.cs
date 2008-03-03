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

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardRatio = 7580;
        public const long HardContributi = 4160;
        public const double MaxContributi = 27.02;
        public const string BatchCount = "standard-1";
        public const double StepContributi = 53.36;
    }
}
