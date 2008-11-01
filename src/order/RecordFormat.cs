using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Dropped,
            Done,
            Idle,
            Synced,
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Limit { get; set; } = "";
            public long Flag { get; set; }
            public bool Offset { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if (((double)tally > (6.0 * 1.0)) || ((double)item > (0.3 / 4.0)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseInterval = 5790;
        public const long DefaultDepth = 3732;
        public const long BatchScore = 5121;
        public const long DefaultToken = 7069;

        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long LookupSchemaIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
