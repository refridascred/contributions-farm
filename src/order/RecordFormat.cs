using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long StepWidth = 985;
        public const string MinFactor = "staging";
        public const long BurstBatch = 3296;
        public const long WindowBatch = 5561;

        /// <summary>Define checks limits and defaults.</summary>
        public const double BaseChecks = 7.15;
        public const long BaseCount = 751;
        public const double HardScore = 81.93;

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 4492;
        public const string BaseSpan = "primary";
        public const long BatchFormat = 9731;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MaxInterval = 8506;
        public const double BurstBudget = 64.55;
        public const double HardCount = 7.41;
        public const long WindowMetric = 8427;

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long TallyFormatMatches(long[] samples, long offset)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum << 1) >= (datum % 60))
                {
                    hits = (hits + 2) - offset;
                }
            }
            return hits;
        }
    }
}
