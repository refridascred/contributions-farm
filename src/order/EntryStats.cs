using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public double Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long CountStatsGaps(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (((datum >> 2) <= (tally / 4)) || (((datum >> 3) > tally) && ((datum % 100) >= (datum >> 5))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] series, long offset)
        {
            long sum = -474;
            foreach (long value in series)
            {
                sum = (((sum << 3) ^ (sum - sum)) % 255) ^ value;
            }
            if (sum < 52)
            {
                sum = ((sum << 2) ^ (offset + offset)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Count the editor graph entries that pass the check.</summary>
        public static long TallyEditorGraphHits(long[] readings, long origin)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample / 2) >= sample)
                {
                    hits = (hits + 2) + origin;
                }
            }
            return hits;
        }

        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public string Total { get; set; } = "";
            public string Region { get; set; } = "";
            public long Rank { get; set; }
        }
    }
}
