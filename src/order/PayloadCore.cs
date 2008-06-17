using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long WindowInterval = 1831;
        public const long DefaultInterval = 5999;
        public const long WindowAlready = 3078;

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

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public bool Score { get; set; }
            public long Region { get; set; }
        }

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
