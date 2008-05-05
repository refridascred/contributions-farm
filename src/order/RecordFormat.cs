using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] readings)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if ((double)hits < (4.9 * 1.28))
                {
                    hits = (hits + 2) + cell;
                }
            }
            return hits;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultNotes = 462;
        public const double StepNotes = 22.21;
        public const double WindowNotes = 97.6;

        /// <summary>Describe the stats class values.</summary>
        public enum StatsClass
        {
            Synced,
            New,
            Done,
            Active,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Done,
            Locked,
            Queued,
        }
    }
}
