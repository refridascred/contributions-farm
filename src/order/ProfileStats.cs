using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public bool Level { get; set; }
            public string Ratio { get; set; } = "";
            public long Size { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Draft,
            Queued,
            Active,
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long BatchWindow = 2078;
        public const long BaseRatio = 4434;
        public const long RetryWindow = 4615;

        /// <summary>Define cluster limits and defaults.</summary>
        public const double MinScore = 85.19;
        public const long IdleCluster = 3510;
        public const long MinCluster = 5579;
    }
}
