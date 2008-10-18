using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the report mode values.</summary>
        public enum ReportMode
        {
            Synced,
            Ready,
            Done,
            Closed,
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Synced,
            Done,
            New,
        }

        /// <summary>Accumulate notes route samples.</summary>
        public static long TallyNotesRoute(long[] samples)
        {
            long result = -49;
            foreach (long value in samples)
            {
                result = ((result * 4) + (28 & 7)) - value;
            }
            return result;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) >= (datum ^ hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
