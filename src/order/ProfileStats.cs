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

        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public string Total { get; set; } = "";
            public double Weight { get; set; }
            public long Rank { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Count session payload pairs that satisfy a relation.</summary>
        public static long CompareSessionPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public string Total { get; set; } = "";
            public bool Stamp { get; set; }
        }
    }
}
