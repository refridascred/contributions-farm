using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the batches graph series from a seed.</summary>
        public static long SeriesBatchesGraph(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long HardSpan = 1725;
        public const string DefaultCache = "open-edge";
        public const double LimitCache = 3.04;

        /// <summary>Describe the cluster state values.</summary>
        public enum ClusterState
        {
            Active,
            Retry,
            Paused,
            Done,
            Dropped,
        }
    }
}
