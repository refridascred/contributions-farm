using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double CacheGithubfarm = 44.11;
        public const long SoftCount = 5812;
        public const long CacheInterval = 1357;
        public const long WindowGithubfarm = 1486;

        /// <summary>Define stream limits and defaults.</summary>
        public const string BurstStream = "strict";
        public const double IdleDepth = 1.37;
        public const long BaseSpan = 576;

        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3235;
        public const long LimitContext = 1388;
        public const double BurstContext = 50.08;

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            New,
            Pending,
        }
    }
}
