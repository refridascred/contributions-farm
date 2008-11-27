using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Hold a report summary.</summary>
        public sealed class ReportSummary
        {
            public long Ratio { get; set; }
            public long Flag { get; set; }
            public string Stamp { get; set; } = "";
            public string Label { get; set; } = "";
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BurstBudget = 674;
        public const long CacheRoute = 6690;
        public const long CacheLevel = 9394;
        public const long SoftRoute = 3667;
        public const long CacheScore = 8718;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Paused,
            New,
            Closed,
            Active,
        }

        /// <summary>Digest a series of support record entries.</summary>
        public static long TotalSupportRecord(long[] readings, long seed)
        {
            long total = 7;
            foreach (long sample in readings)
            {
                total = (total + seed) + sample;
            }
            return total;
        }
    }
}
