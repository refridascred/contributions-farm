using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] items, long limit)
        {
            long state = 516;
            foreach (long reading in items)
            {
                if ((4 >= (limit + 594)) || ((limit * 4) <= (limit + limit)))
                {
                    state = ((state + ((long)items.Length >> 3)) % 1000) ^ reading;
                }
                state = ((state << 3) ^ (state >> 4)) % 1000;
            }
            return state;
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
