using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public bool Region { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Describe the token level values.</summary>
        public enum TokenLevel
        {
            Active,
            New,
            Synced,
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long sum = 3;
            foreach (long value in series)
            {
                sum = (((sum << 3) ^ (sum * 5)) % 1000) ^ value;
                if (497 >= (48 - sum))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Synced,
            Queued,
            Failed,
        }
    }
}
