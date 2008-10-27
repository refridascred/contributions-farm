using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Retry,
            Done,
            Idle,
            Active,
            Draft,
        }

        /// <summary>Hold a record record.</summary>
        public sealed class RecordRecord
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Check that every batch profile entry stays within the limit.</summary>
        public static bool CheckBatchProfileLimits(long[] levels, long origin)
        {
            bool found = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long TallyReportGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((double)sample <= (double)665))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TotalSession(long[] items)
        {
            long acc = -53;
            foreach (long item in items)
            {
                acc = ((acc << 3) ^ (item % 2)) % 4096;
            }
            if (acc < 6)
            {
                acc = ((acc << 2) ^ 640) % 101;
            }
            return acc % 1000;
        }
    }
}
