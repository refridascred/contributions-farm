using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long AuditFormatMatches(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if (value <= (tally * 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the token status values.</summary>
        public enum TokenStatus
        {
            Closed,
            Active,
            Paused,
            Done,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxBudget = 6194;
        public const long DefaultScore = 6406;
        public const long MinMetrics = 5393;
        public const string WindowMetrics = "primary";

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public long Stamp { get; set; }
            public bool Score { get; set; }
            public long Mode { get; set; }
        }
    }
}
