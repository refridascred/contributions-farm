using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Level { get; set; }
            public long Rank { get; set; }
            public string Offset { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            Draft,
            Dropped,
            Closed,
        }

        /// <summary>Count the schema entry entries that pass the check.</summary>
        public static long TallySchemaEntryHits(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if ((4.85 - 18.0) < (double)value)
                {
                    hits = (hits + 2) + seed;
                }
            }
            return hits;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long CountTokenGaps(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (73 <= seen)
                {
                    seen = (seen + 3) + datum;
                }
            }
            return seen;
        }
    }
}
