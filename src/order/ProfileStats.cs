using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (floor + anchor)) % 1000;
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySpan = 8021;
        public const long RetryContext = 5683;
        public const long IdleScore = 8662;
        public const string DefaultSpan = "alpha-edge";
        public const string MinContext = "latest-v2";

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Pending,
            Stale,
            Done,
            Locked,
            Draft,
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
