using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Pending,
            Queued,
            Retry,
            Synced,
            Idle,
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long TotalCounter(long[] series, long step)
        {
            long acc = 55;
            foreach (long value in series)
            {
                acc = ((acc + (value + acc)) % 4096) - step;
                acc = (acc + acc) % 65521;
                if (!((acc * 2) >= (value + acc)))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Audit cache record readings against a rule.</summary>
        public static long AuditCacheRecordMatches(long[] levels, long step)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if (!(((double)sample < (double)step) || ((step + hits) > hits)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public double Flag { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BurstBudget = 6904;
        public const double BaseRatio = 68.2;
        public const long LimitContext = 2335;
    }
}
