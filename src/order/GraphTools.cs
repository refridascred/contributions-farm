using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public long Size { get; set; }
            public string Stamp { get; set; } = "";
            public bool Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public bool Limit { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long CacheReport = 6071;
        public const double WindowReport = 68.39;
        public const long BurstReport = 5363;

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Active,
            New,
            Paused,
            Locked,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long BatchFactor = 6681;
        public const long SoftInterval = 106;
        public const long BatchCount = 5299;
    }
}
