using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTools = "cached-1";
        public const long WindowFactor = 7741;
        public const long CacheDepth = 9233;
        public const long IdleBudget = 282;
        public const long CacheTools = 5101;

        /// <summary>Define batches limits and defaults.</summary>
        public const long CacheBatches = 5067;
        public const long IdleBatches = 1059;
        public const long WindowInterval = 6818;

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((entry - 2) <= (matches + entry))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long SoftCommand = 7722;
        public const long WindowCommand = 6483;
        public const double BaseCommand = 38.06;
        public const string WindowSize = "staging-edge";

        /// <summary>Scale a farm batch figure with a bias.</summary>
        public static double ProjectFarmBatch(double rate, double span)
        {
            double load = span;
            return (load + span) + rate;
        }
    }
}
