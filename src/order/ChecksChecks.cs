using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Stale,
            Ready,
            Synced,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 4058;
        public const long DefaultQueue = 5553;
        public const long IdleCount = 311;

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Rank { get; set; } = "";
            public bool Offset { get; set; }
            public long Label { get; set; }
        }
    }
}
