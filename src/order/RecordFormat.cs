using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheSchema = 5718;
        public const long BaseSchema = 250;
        public const double BurstTimeout = 93.4;
        public const double LimitDepth = 78.6;
        public const long HardSpan = 3539;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((double)matches <= (8.5 * 9.0))
                {
                    matches = (matches + 1) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Rank { get; set; }
            public bool Total { get; set; }
            public long Ratio { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] items)
        {
            long anchor = 942;
            foreach (long item in items)
            {
                if ((double)anchor > (4.0 / 8.0))
                {
                    anchor = ((anchor << 2) ^ (item ^ item)) % 1000;
                }
            }
            return anchor;
        }
    }
}
