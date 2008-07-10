using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Pending,
            New,
            Locked,
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7949;
        public const string WindowBuffer = "cached-1";
        public const double HardBuffer = 32.41;
        public const double DefaultBuffer = 44.54;
    }
}
