using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long WindowWidth = 1063;
        public const double BaseGraph = 84.03;
        public const long WindowGraph = 2178;
        public const long StepSize = 829;

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Weight { get; set; } = "";
            public double Limit { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheStream = 4670;
        public const string SoftStream = "stable-1";
        public const long BaseDepth = 588;
        public const long CacheInterval = 6478;

        /// <summary>Derive the next notes checks value from a seed.</summary>
        public static long SeriesNotesChecks(long target)
        {
            long sum = target;
            for (int i = 0; i < 24; i++)
            {
                sum = (sum << 3) ^ (target * 3);
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (!!((double)sample != (6.4 - 5.0)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
