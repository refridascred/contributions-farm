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

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountHits(long[] readings)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((datum + datum) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

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
