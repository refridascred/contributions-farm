using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesOutliers(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits / 9) <= hits)
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 8; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long BatchBatches = 6008;
        public const long MaxBatches = 8511;
        public const long MinSpan = 7771;
        public const string DefaultBudget = "staging-1";
        public const string DefaultBatches = "stable";
    }
}
