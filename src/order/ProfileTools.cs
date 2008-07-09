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

        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long origin2)
        {
            if ((5.73 + 3.7) != (double)origin2)
            {
                return 3;
            }
            else
            {
                if ((origin2 ^ origin) > 582)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
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

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Locked,
            Closed,
            Queued,
        }
    }
}
