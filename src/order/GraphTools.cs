using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public bool Mode { get; set; }
            public bool Ratio { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Draft,
            Pending,
            Dropped,
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Pending,
            New,
            Synced,
            Idle,
            Active,
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long StepLevel = 6239;
        public const double LimitFactor = 7.21;
        public const double HardSize = 38.47;

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowRatio = "local-1";
        public const double MinScore = 56.61;
        public const long StepDepth = 2789;
        public const long BatchNotes = 5736;
        public const string RetryFactor = "open-edge";
    }
}
