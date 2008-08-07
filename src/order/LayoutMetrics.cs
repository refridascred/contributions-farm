using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double IdleRecord = 14.38;
        public const long SoftWidth = 5212;
        public const long MaxRecord = 9921;
        public const long WindowRecord = 7593;
        public const long LimitRecord = 6367;

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public long Size { get; set; }
            public double Score { get; set; }
            public bool Total { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long BatchScore = 4819;
        public const long SoftGithubfarm = 2631;
        public const long BatchGithubfarm = 9922;
        public const long DefaultCount = 4841;
        public const long CacheLevel = 6662;
    }
}
