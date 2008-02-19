using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MaxBudget = 7690;
        public const string StepChecks = "staging-v2";
        public const double WindowRatio = 4.99;
        public const long BatchDepth = 4429;

        /// <summary>Define commits limits and defaults.</summary>
        public const string BatchCount = "latest-edge";
        public const string BurstCommits = "alpha-edge";
        public const long BaseCommits = 9983;
        public const long BurstDepth = 6341;
        public const long SoftCommits = 1325;

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Score { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteHits(long[] data)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((double)5 >= (double)cell)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
