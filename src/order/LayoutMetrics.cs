using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long MaxCount = 4919;
        public const long DefaultCount = 2250;
        public const double WindowBuffer = 94.93;
        public const long CacheFactor = 1198;

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Synced,
            Draft,
            Ready,
            Queued,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Idle,
            Closed,
            Draft,
            Failed,
        }
    }
}
