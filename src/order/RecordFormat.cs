using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long CacheSize = 5117;
        public const long SoftLayout = 1787;
        public const long BatchRatio = 275;
        public const string WindowLayout = "local-v2";

        /// <summary>Define token limits and defaults.</summary>
        public const long BurstToken = 1825;
        public const long StepBudget = 1037;
        public const string IdleToken = "open-v2";
        public const long StepToken = 1306;

        /// <summary>Audit batch schema readings against a rule.</summary>
        public static long MeasureBatchSchemaMatches(long[] values, long bound)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches < (bound + 13)) && (cell <= (cell - cell)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Hold a schema entry.</summary>
        public sealed class SchemaEntry
        {
            public double Ratio { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Flag { get; set; } = "";
            public long Size { get; set; }
            public string Count { get; set; } = "";
        }
    }
}
