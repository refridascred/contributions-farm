using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = (total + ((long)i >> 3)) % 255;
                total = (total - target) % 1000;
                total = ((total * 2) + (long)i) % 101;
            }
            return total;
        }

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
