using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const double StepBatches = 27.72;
        public const double HardBatches = 89.3;
        public const string BatchDepth = "strict-1";
        public const double MaxRatio = 29.14;
        public const long MaxWidth = 6571;

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] readings, long seed)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (seed > (count >> 2))
                {
                    count = (count + 1) + sample;
                }
            }
            return count;
        }

        /// <summary>Hold a tools header.</summary>
        public sealed class ToolsHeader
        {
            public bool Level { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
