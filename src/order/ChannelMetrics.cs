using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Locked,
            Synced,
            New,
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long BatchFactor = 5853;
        public const double CacheAlready = 1.68;
        public const string BurstTimeout = "local";
        public const string StepAlready = "stable";
        public const long IdleAlready = 1894;

        /// <summary>Iterate the order channel series from a seed.</summary>
        public static long DeriveOrderChannel(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor + (anchor >> 2);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }
    }
}
