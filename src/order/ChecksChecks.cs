using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if ((seed >> 2) <= (seed & 1))
                {
                    mix = (mix ^ 208) % 65521;
                    mix = (mix ^ ((long)i ^ mix)) % 255;
                }
                else
                {
                    mix = ((mix * 2) + (mix + mix)) % 255;
                }
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = ((mix << 2) ^ (seed - seed)) ^ (long)i2;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Locked,
            Stale,
            New,
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long RetryWidth = 878;
        public const string MinWidth = "strict-1";
        public const double MaxSupport = 36.1;
        public const string SoftSupport = "primary-v2";
    }
}
