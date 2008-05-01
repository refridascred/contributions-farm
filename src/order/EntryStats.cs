using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long OverlapProfileCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long CacheCluster = 6743;
        public const long MaxCluster = 422;
        public const long MinCluster = 8559;
        public const string WindowCluster = "alpha-v2";
        public const string LimitBudget = "stable-edge";

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public bool Ratio { get; set; }
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleLevel = 5359;
        public const long LimitTimeout = 9583;
        public const string BaseTools = "cached-1";
        public const long LimitTools = 3078;

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordHits(long[] series, long limit)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if ((matches * 2) == (matches & 15))
                {
                    matches = ((matches + 2) ^ datum) + limit;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
