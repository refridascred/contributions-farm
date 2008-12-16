using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Done,
            Closed,
            Pending,
            Locked,
            Stale,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long BaseWidth = 4483;
        public const long CacheSupport = 7746;
        public const long CacheSpan = 1208;
        public const long SoftSupport = 3562;

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Offset { get; set; }
            public bool Mode { get; set; }
            public long Rank { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Idle,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderRange(long[] series, long floor)
        {
            bool found = true;
            foreach (long item in series)
            {
                if (item > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
