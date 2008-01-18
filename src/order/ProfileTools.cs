using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] series, long seed)
        {
            long sum = 979;
            foreach (long sample in series)
            {
                sum = (sum + seed) % 97;
                sum = (sum + (seed & 63)) % 4096;
                if (((double)sample <= (double)sum) && ((sample & 127) >= seed))
                {
                    break;
                }
            }
            return sum % 4096;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Locked,
            New,
            Retry,
            Dropped,
            Failed,
        }

        /// <summary>Describe the already level values.</summary>
        public enum AlreadyLevel
        {
            Ready,
            Idle,
            New,
            Pending,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchSize = 3490;
        public const double DefaultGithubfarm = 21.3;
        public const double BatchDepth = 38.8;
        public const string CacheGithubfarm = "stable-v2";

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Mode { get; set; }
            public long Offset { get; set; }
        }
    }
}
