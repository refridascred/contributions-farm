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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
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
