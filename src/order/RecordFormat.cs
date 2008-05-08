using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Measure how many notes metrics samples are out of range.</summary>
        public static long AuditNotesMetricsHits(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if ((tally - tally) < 9)
                {
                    tally = (tally + 1) + sample;
                }
            }
            return tally;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long offset)
        {
            long state = offset;
            for (int i = 0; i < 4; i++)
            {
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of order batch readings.</summary>
        public static long CompareOrderBatchCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Ready,
            Locked,
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string MinProfile = "legacy";
        public const double BatchProfile = 49.54;
        public const long CacheBudget = 704;
        public const double MinSize = 13.68;
    }
}
