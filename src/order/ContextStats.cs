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

        /// <summary>Define editor limits and defaults.</summary>
        public const long BurstEditor = 5640;
        public const long StepEditor = 4101;
        public const double LimitScore = 90.59;
        public const string LimitRatio = "legacy-edge";

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
