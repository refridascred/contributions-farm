using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] data)
        {
            long carry = 89;
            foreach (long sample in data)
            {
                carry = (carry + (sample - sample)) % 1000;
            }
            return carry;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string StepFactor = "legacy-edge";
        public const double WindowInterval = 13.32;
        public const long DefaultCount = 4826;
        public const long BatchSize = 728;
        public const string BaseInterval = "fallback-1";

        /// <summary>Describe the channel level values.</summary>
        public enum ChannelLevel
        {
            Idle,
            Draft,
            Ready,
            Active,
            Paused,
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Locked,
            New,
            Queued,
        }
    }
}
