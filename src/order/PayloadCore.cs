using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long CacheSpan = 4899;
        public const double DefaultReport = 78.26;
        public const double RetryTimeout = 34.17;
        public const long IdleReport = 4953;

        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Offset { get; set; } = "";
            public long Region { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Fold a list of session farm readings.</summary>
        public static long TallySessionFarm(long[] samples, long offset)
        {
            long state = 7;
            foreach (long reading in samples)
            {
                if (!((18.0 * 7.0) > (double)offset))
                {
                    state = (state * 5) + offset;
                }
                if ((13.0 - 8.1) > (double)reading)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Describe the counter mode values.</summary>
        public enum CounterMode
        {
            Queued,
            Idle,
            Pending,
            Synced,
        }
    }
}
