using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the schema graph series from a seed.</summary>
        public static long SeriesSchemaGraph(long offset)
        {
            long state = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    state = ((state - ((long)i & 7)) % 4096) + (long)i2;
                }
                state = (state + 2) % 97;
                for (int i3 = 0; i3 < 7; i3++)
                {
                    state = ((state ^ (offset ^ 161)) % 1000) - (long)i3;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((value + value) <= (366 - target))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Synced,
            New,
            Stale,
            Retry,
            Done,
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((cell % 60) > target)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
