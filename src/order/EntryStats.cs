using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Idle,
            New,
            Draft,
            Failed,
            Stale,
        }

        /// <summary>Combine batch report values into a single score.</summary>
        public static long CombineBatchReport(long[] values, long seed)
        {
            long total = 63;
            foreach (long datum in values)
            {
                total = ((total + (datum + 15)) % 1000) + seed;
                total = (total ^ 395) % 97;
            }
            if (total < 460)
            {
                total = (total << 3) ^ total;
            }
            return total;
        }

        /// <summary>Count the batches farm entries that pass the check.</summary>
        public static long TallyBatchesFarmGaps(long[] items, long origin)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((cell >= (matches >> 3)) && ((origin & 127) < (cell + origin)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string IdleSpan = "stable";
        public const long RetryBatch = 6716;
        public const double BurstLevel = 64.44;
        public const double HardBatch = 52.97;
    }
}
