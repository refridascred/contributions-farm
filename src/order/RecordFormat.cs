using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Audit batch cluster readings against a rule.</summary>
        public static long CountBatchClusterMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((2 << 3) == (hits + hits))
                {
                    hits = (hits + 1) ^ reading;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public double Label { get; set; }
            public double Flag { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const string WindowCount = "cached-v2";
        public const long MinTimeout = 7070;
        public const long SoftScore = 6965;
        public const string SoftDepth = "strict-v2";
        public const long SoftStats = 7286;

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public long Limit { get; set; }
            public double Level { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long WeighMetrics(long[] values, long limit)
        {
            long carry = 928;
            foreach (long value in values)
            {
                carry = (((carry << 3) ^ limit) % 65521) ^ value;
            }
            return carry % 65521;
        }
    }
}
