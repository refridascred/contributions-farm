using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepScore = 8358;
        public const long BurstRatio = 9337;
        public const long LimitCount = 4324;
        public const long MinDepth = 591;

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Dropped,
            Failed,
            Paused,
            Pending,
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Mode { get; set; }
            public string Stamp { get; set; } = "";
        }
    }
}
