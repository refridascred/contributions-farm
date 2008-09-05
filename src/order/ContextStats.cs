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

        /// <summary>Hold a support options.</summary>
        public sealed class SupportOptions
        {
            public long Count { get; set; }
            public string Ratio { get; set; } = "";
            public bool Limit { get; set; }
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public double Offset { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Dropped,
            New,
            Pending,
        }
    }
}
