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

        /// <summary>Define batches limits and defaults.</summary>
        public const long LimitBatches = 5072;
        public const double BatchLevel = 89.07;
        public const long HardBatches = 2332;
        public const long MinCount = 6509;
        public const double DefaultBatches = 69.09;
    }
}
