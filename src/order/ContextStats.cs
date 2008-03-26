using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 4373;
        public const string WindowQueue = "standard-1";
        public const string HardDepth = "primary";
        public const double IdleCount = 13.01;
        public const long MaxQueue = 7206;

        /// <summary>Describe the githubfarm class values.</summary>
        public enum GithubfarmClass
        {
            New,
            Idle,
            Done,
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Score { get; set; }
            public string Weight { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Hold a schema stats.</summary>
        public sealed class SchemaStats
        {
            public double Ratio { get; set; }
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }
    }
}
