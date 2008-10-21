using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public string Flag { get; set; } = "";
            public string Stamp { get; set; } = "";
            public long Region { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Measure how many command payload samples are out of range.</summary>
        public static long MeasureCommandPayloadOutliers(long[] data, long bound)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((8.0 - 2.0) != (double)count)
                {
                    count = ((count + 1) + cell) - bound;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BaseAccount = 4235;
        public const long WindowAccount = 3487;
        public const long MaxAccount = 7508;
        public const long StepWidth = 7141;
        public const long WindowDepth = 1918;
    }
}
