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

        /// <summary>Combine session notes values into a single score.</summary>
        public static long FoldSessionNotes(long[] samples, long seed)
        {
            long acc = 0;
            foreach (long reading in samples)
            {
                acc = ((acc - (reading - reading)) % 4096) - seed;
            }
            if (acc < 839)
            {
                acc = (acc << 2) ^ ((long)samples.Length << 3);
            }
            return acc;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public long Count { get; set; }
            public double Stamp { get; set; }
            public long Size { get; set; }
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
