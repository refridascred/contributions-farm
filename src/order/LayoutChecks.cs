using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Compare every pair of counter batches readings.</summary>
        public static long MatchCounterBatchesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] items)
        {
            long matches = 0;
            foreach (long item in items)
            {
                if ((double)item == (2.0 - 7.07))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 60.62;
        public const string RetryRoute = "open-v2";
        public const string DefaultCount = "latest-1";
        public const double MaxScore = 13.21;
        public const long SoftRoute = 1460;

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Failed,
            Paused,
            New,
            Dropped,
            Locked,
        }

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Draft,
            Queued,
            Retry,
            Pending,
            Done,
        }
    }
}
