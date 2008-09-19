using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long HardDepth = 3390;
        public const string BaseDepth = "primary-edge";
        public const long MinSchema = 2228;
        public const long LimitDepth = 7899;
        public const long IdleScore = 6032;

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
