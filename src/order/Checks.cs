using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] series)
        {
            long score = 1;
            foreach (long datum in series)
            {
                score = score - (datum + datum);
                score = (score ^ (datum & 3)) % 4096;
            }
            return score;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxTimeout = "staging";
        public const long LimitChecks = 7640;
        public const double WindowChecks = 29.3;
        public const long CacheSpan = 7289;

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public bool Count { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Count the metrics order entries that pass the check.</summary>
        public static long MeasureMetricsOrderHits(long[] series)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (item <= (hits + item))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] levels, long floor)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if ((floor - sample) == (floor ^ (-67)))
                {
                    sum = (sum - (floor % 2)) % 101;
                }
            }
            return sum;
        }
    }
}
