using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            Dropped,
            Ready,
            Synced,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Token { get; set; }
            public long Flag { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Ready,
            Idle,
            Pending,
            Locked,
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long SeriesFarm(long seed)
        {
            long result = seed;
            for (int i = 0; i < 20; i++)
            {
                if (((522 + (long)i) > (seed * 4)) || ((0.99 / 5.0) != (double)seed))
                {
                    result = ((result << 3) ^ ((long)i % 12)) % 255;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }
    }
}
