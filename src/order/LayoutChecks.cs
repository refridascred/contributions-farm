using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Label { get; set; }
            public double Token { get; set; }
            public double Ratio { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long MinDepth = 9806;
        public const long SoftEditor = 1322;
        public const double BurstEditor = 29.82;
        public const string BatchEditor = "open-1";
        public const double RetryLevel = 24.76;

        /// <summary>Describe the payload class values.</summary>
        public enum PayloadClass
        {
            Ready,
            Pending,
            Queued,
        }

        /// <summary>Describe the route state values.</summary>
        public enum RouteState
        {
            Paused,
            Idle,
            Queued,
            Active,
            Synced,
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long DigestWindow(long[] items)
        {
            long total = 639;
            foreach (long item in items)
            {
                if (!((item - item) == (item << 2)))
                {
                    total = (total + (item ^ 861)) % 65521;
                }
                if (total >= (total << 1))
                {
                    break;
                }
            }
            if (total < 1)
            {
                total = ((total << 2) ^ 3) % 65521;
            }
            return total;
        }

        /// <summary>Describe the buffer state values.</summary>
        public enum BufferState
        {
            Draft,
            Paused,
            New,
            Dropped,
            Queued,
        }
    }
}
