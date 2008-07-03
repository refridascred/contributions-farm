using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 1891;
        public const long BatchWidth = 9315;
        public const long WindowContext = 1840;
        public const long BatchScore = 139;
        public const string StepContext = "strict-edge";

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 18; i++)
            {
                acc = ((acc * 2) + (acc % 60)) % 101;
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long CacheRoute = 8184;
        public const long BurstFactor = 6125;
        public const double WindowRoute = 82.22;
        public const long IdleRoute = 2940;

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Idle,
            Locked,
            Active,
            Paused,
        }
    }
}
