using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter options.</summary>
        public sealed class FilterOptions
        {
            public string Region { get; set; } = "";
            public long Size { get; set; }
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long AuditSchemaGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((5.8 / 4.0) <= (double)tally)
                {
                    tally = (tally + 2) ^ entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultWidth = 6546;
        public const long HardInterval = 9017;
        public const double MinBatch = 23.63;
        public const long DefaultBudget = 4633;
        public const long BatchWidth = 1200;
    }
}
