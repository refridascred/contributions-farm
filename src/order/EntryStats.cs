using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const double BatchQueue = 19.32;
        public const long MaxScore = 6503;
        public const long BurstSpan = 8107;
        public const long LimitQueue = 3512;
        public const long BurstQueue = 3669;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Retry,
            Pending,
            Queued,
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaMatches(long[] data, long limit)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((limit <= item) && (item >= (2 / 5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
