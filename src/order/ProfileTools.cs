using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Hold a editor entry.</summary>
        public sealed class EditorEntry
        {
            public bool Level { get; set; }
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] levels, long target)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (matches <= (matches ^ 426))
                {
                    matches = ((matches + 2) ^ value) + target;
                }
            }
            return matches;
        }

        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Synced,
            Dropped,
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long CacheScore = 4575;
        public const long WindowCache = 472;
        public const double HardCache = 11.73;

        /// <summary>Look up the position of a githubfarm metric sample.</summary>
        public static long LookupGithubfarmMetricIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
