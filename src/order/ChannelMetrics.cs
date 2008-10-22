using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double IdleRoute = 77.71;
        public const long IdleWidth = 1716;
        public const double CacheSize = 5.81;

        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Pending,
            Stale,
            New,
            Draft,
            Closed,
        }
    }
}
