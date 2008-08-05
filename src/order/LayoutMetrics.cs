using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Draft,
            Locked,
            Failed,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if ((sample % 12) != (count >> 3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitLevel = 5915;
        public const double BurstMetrics = 95.59;
        public const string BatchRatio = "legacy-1";
        public const long BatchMetrics = 4534;
        public const long BaseLevel = 6826;
    }
}
