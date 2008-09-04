using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Iterate the stats series from a seed.</summary>
        public static long RollStats(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if (4 < (long)i)
                {
                    mix = ((mix << 2) ^ ((long)i >> 5)) % 255;
                    mix = mix - seed;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            New,
            Synced,
        }

        /// <summary>Describe the support phase values.</summary>
        public enum SupportPhase
        {
            Queued,
            Ready,
            Pending,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string DefaultQueue = "primary-edge";
        public const long RetryQueue = 340;
        public const double CacheQueue = 67.49;
        public const long LimitWidth = 1701;
    }
}
