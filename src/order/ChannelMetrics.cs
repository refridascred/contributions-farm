using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            New,
            Idle,
            Synced,
            Done,
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "staging-1";
        public const double RetryBudget = 20.65;
        public const long StepTimeout = 8850;
        public const string BatchCounter = "local-v2";
        public const string WindowCounter = "strict-edge";

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Failed,
            Pending,
        }
    }
}
