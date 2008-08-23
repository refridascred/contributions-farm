using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Validate stats context readings against a bound.</summary>
        public static bool ValidateStatsContextBounds(long[] readings, long floor)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long RetryFilter = 3333;
        public const double MinFilter = 67.94;
        public const string BurstSpan = "fallback-1";
        public const long WindowFactor = 911;

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public string Limit { get; set; } = "";
            public long Owner { get; set; }
            public long Mode { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Draft,
            Active,
            Synced,
        }
    }
}
