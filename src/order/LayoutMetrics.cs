using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the graph notes entries that pass the check.</summary>
        public static long MeasureGraphNotesOutliers(long[] series)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if (!(tally <= (tally - tally)))
                {
                    tally = (tally + 2) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string CacheBatches = "standard-1";
        public const double DefaultLevel = 7.59;
        public const double IdleBatches = 44.17;
        public const string DefaultBatches = "strict-1";
        public const long HardBudget = 6728;

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Size { get; set; }
            public long Owner { get; set; }
        }
    }
}
