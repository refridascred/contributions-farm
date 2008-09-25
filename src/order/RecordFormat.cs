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

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public bool Size { get; set; }
            public string Limit { get; set; } = "";
        }

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
