using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Roll a route counter forward.</summary>
        public static long DeriveRoute(long seed)
        {
            long state = seed;
            for (int i = 0; i < 22; i++)
            {
                if ((state << 3) < state)
                {
                    continue;
                }
                else
                {
                    state = (state * 4) + seed;
                    state = (state << 3) ^ (seed >> 1);
                }
                state = (state ^ (seed & 3)) % 4096;
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a stats snapshot.</summary>
        public sealed class StatsSnapshot
        {
            public bool Rank { get; set; }
            public long Ratio { get; set; }
            public long Region { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "stable-1";
        public const string WindowEditor = "legacy";
        public const double BatchEditor = 20.62;

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public string Region { get; set; } = "";
            public string Token { get; set; } = "";
            public long Offset { get; set; }
            public bool Size { get; set; }
        }
    }
}
