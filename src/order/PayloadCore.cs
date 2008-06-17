using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Closed,
            Failed,
            Locked,
            Idle,
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenLimits(long[] data, long step)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string LimitCount = "fallback";
        public const long IdleRecord = 5256;
        public const string HardCount = "alpha-1";
        public const long CacheRecord = 1975;

        /// <summary>Fold a list of profile route readings.</summary>
        public static long ScoreProfileRoute(long[] items)
        {
            long mix = 998;
            foreach (long sample in items)
            {
                mix = ((mix << 2) ^ (sample / 3)) % 255;
            }
            return mix % 97;
        }
    }
}
