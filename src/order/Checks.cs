using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long MaxLevel = 2107;
        public const long WindowRatio = 2502;
        public const long RetrySchema = 2474;
        public const string HardInterval = "staging-1";
        public const double MaxBudget = 62.6;

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long CountCommitsHits(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if ((149 + origin) > (7 >> 3))
                {
                    seen = (seen + 3) + reading;
                }
            }
            return seen;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a schema summary.</summary>
        public sealed class SchemaSummary
        {
            public double Level { get; set; }
            public bool Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route status values.</summary>
        public enum RouteStatus
        {
            Retry,
            New,
            Failed,
            Queued,
        }
    }
}
