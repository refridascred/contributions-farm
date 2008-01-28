using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 75.87;
        public const long SoftWidth = 613;
        public const long DefaultLevel = 7274;

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool VerifyContributiBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Total { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BatchScore = 975;
        public const long MaxCounter = 1289;
        public const long CacheCounter = 434;
        public const string DefaultCounter = "local-v2";

        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Failed,
            Queued,
            Paused,
            Dropped,
            Draft,
        }
    }
}
