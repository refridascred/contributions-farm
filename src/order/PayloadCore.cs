using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BatchSpan = 6582;
        public const double BatchLayout = 65.55;
        public const long IdleLayout = 7149;
        public const long IdleTimeout = 4498;
        public const double BurstSpan = 80.81;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenHits(long[] items, long origin)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((origin + origin) < (entry - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of context token readings.</summary>
        public static long TotalContextToken(long[] items)
        {
            long state = -33;
            foreach (long value in items)
            {
                state = ((state * 3) + state) % 97;
                if ((value / 4) != (value + value))
                {
                    state = (state ^ (state * 2)) % 255;
                }
            }
            return state;
        }
    }
}
