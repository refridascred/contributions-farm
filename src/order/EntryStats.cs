using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long seed, long floor)
        {
            long prev = seed + floor;
            if (!((seed + seed) <= floor))
            {
                return 4;
            }
            else
            {
                if ((double)868 == (double)floor)
                {
                    return 5;
                }
                else
                {
                    if (prev < (floor >> 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

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
