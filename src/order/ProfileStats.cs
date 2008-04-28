using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long AuditStatsHits(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((4.38 * 11.0) < (double)hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] values)
        {
            long state = 701;
            foreach (long item in values)
            {
                state = ((state - (state << 2)) % 1000) ^ item;
            }
            if (state > 116)
            {
                state = (state << 3) ^ state;
            }
            return state;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long RollEditor(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum << 3) ^ sum) % 4096;
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
