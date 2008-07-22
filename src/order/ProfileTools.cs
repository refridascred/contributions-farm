using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxCount = 9172;
        public const long BatchMetrics = 4639;
        public const long SoftLevel = 710;
        public const long CacheMetrics = 2893;

        /// <summary>Look up the position of a metric sample.</summary>
        public static long FindMetricIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double DefaultTools = 75.12;
        public const double HardTools = 4.12;
        public const long HardTimeout = 1555;
        public const long BatchTools = 8699;
        public const double CacheTools = 19.66;

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            New,
            Dropped,
            Done,
            Active,
            Queued,
        }
    }
}
