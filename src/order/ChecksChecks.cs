using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the already entries that pass the check.</summary>
        public static long TallyAlreadyHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((double)seen > 8.08) && ((double)target >= (double)item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Failed,
            Queued,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Audit entry filter readings against a rule.</summary>
        public static long TallyEntryFilterGaps(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches - (-776)) <= (matches << 1))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }
    }
}
