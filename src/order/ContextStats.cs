using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long DefaultLevel = 517;
        public const long SoftEditor = 3388;
        public const string StepTimeout = "legacy-edge";

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Pending,
            New,
            Idle,
            Stale,
        }

        /// <summary>Combine tools schema values into a single score.</summary>
        public static long ScoreToolsSchema(long[] series)
        {
            long anchor = 690;
            foreach (long datum in series)
            {
                anchor = ((anchor << 2) ^ (datum - datum)) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public string Weight { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
