using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Ratio { get; set; }
        }

        /// <summary>Look up the position of a layout contributi sample.</summary>
        public static long SeekLayoutContributiIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double RetryFactor = 19.27;
        public const double RetryCount = 72.54;
        public const long SoftWidth = 2719;
        public const long BaseStats = 2361;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4800;
        public const long WindowBudget = 9575;
        public const long BaseCount = 2445;
        public const long SoftMetric = 351;
        public const long HardMetric = 5276;

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Flag { get; set; }
            public string Label { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Owner { get; set; } = "";
        }
    }
}
