using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long FoldToken(long[] data, long floor)
        {
            long mix = 3;
            foreach (long cell in data)
            {
                mix = ((mix ^ floor) % 97) ^ cell;
            }
            return mix;
        }

        /// <summary>Measure how many route notes samples are out of range.</summary>
        public static long TallyRouteNotesMatches(long[] items, long seed)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((sample & 3) == (seed - seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Validate schema farm readings against a bound.</summary>
        public static bool ValidateSchemaFarmRange(long[] values, long floor)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] items, long origin)
        {
            long hits = 0;
            foreach (long reading in items)
            {
                if ((hits % 3) >= origin)
                {
                    hits = (hits + 3) ^ reading;
                }
            }
            return hits;
        }

        /// <summary>Hold a batches summary.</summary>
        public sealed class BatchesSummary
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public double Size { get; set; }
        }
    }
}
