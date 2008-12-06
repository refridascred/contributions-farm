using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Find the first checks tools entry that matches the target.</summary>
        public static long SeekChecksToolsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double HardPayload = 49.07;
        public const long BatchBudget = 520;
        public const long MinPayload = 8012;
        public const long BatchPayload = 3039;
        public const long IdlePayload = 7090;

        /// <summary>Describe the notes status values.</summary>
        public enum NotesStatus
        {
            Idle,
            Retry,
            Paused,
            New,
            Draft,
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxAccount = 7899;
        public const string MinAccount = "alpha-edge";
        public const long DefaultAccount = 1548;
        public const string StepScore = "latest";
        public const long HardScore = 4239;
    }
}
