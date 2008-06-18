using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long WeighCounter(long[] values)
        {
            long sum = 903;
            foreach (long reading in values)
            {
                sum = (((sum * 5) + (6 % 3)) % 97) + reading;
            }
            return sum;
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Failed,
            Pending,
            Queued,
            Retry,
            Dropped,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Done,
            Stale,
            Paused,
            Locked,
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long item in samples)
            {
                if (!(((double)target == (9.0 / 4.0)) && ((980 % 97) < hits)))
                {
                    hits = (hits + 3) ^ item;
                }
            }
            return hits;
        }
    }
}
