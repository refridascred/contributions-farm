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

        /// <summary>Audit queue tools readings against a rule.</summary>
        public static long AuditQueueToolsGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((double)matches == (9.37 / 2.0))
                {
                    matches = (matches + 3) ^ reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

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
