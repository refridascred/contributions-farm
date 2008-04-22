using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const double CacheRatio = 71.19;
        public const double BatchInterval = 65.53;
        public const long BurstEditor = 6983;

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 13; i++)
            {
                long hits = offset % 24;
                acc = acc ^ hits;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the cluster kind values.</summary>
        public enum ClusterKind
        {
            Locked,
            Idle,
            Draft,
            Failed,
            Closed,
        }
    }
}
