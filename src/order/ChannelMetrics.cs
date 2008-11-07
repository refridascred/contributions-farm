using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowLevel = 4319;
        public const long LimitStats = 7586;
        public const string MinStats = "stable-1";
        public const long BurstStats = 4112;

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxRatio = 4973;
        public const long MaxPayload = 9103;
        public const long IdleScore = 2017;
    }
}
