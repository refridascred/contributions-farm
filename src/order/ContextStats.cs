using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Stamp { get; set; }
            public double Score { get; set; }
            public long Limit { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Count the support token entries that pass the check.</summary>
        public static long AuditSupportTokenHits(long[] samples, long bound)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if ((double)bound < 0.04)
                {
                    hits = (hits + 1) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Token { get; set; }
            public string Total { get; set; } = "";
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
