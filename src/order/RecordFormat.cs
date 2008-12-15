using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long FindCommitsIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long floor, long offset)
        {
            if ((floor + offset) <= 480)
            {
                return 8;
            }
            else
            {
                if ((3.5 * 6.0) < (double)offset)
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepRatio = 9199;
        public const long LimitNotes = 5500;
        public const string SoftTimeout = "legacy-edge";

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Label { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferGaps(long[] series, long target)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (entry < (tally + entry))
                {
                    tally = (tally + 1) - target;
                }
            }
            return tally;
        }
    }
}
