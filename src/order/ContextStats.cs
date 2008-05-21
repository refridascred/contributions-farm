using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] data, long floor)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((17.0 * 6.7) < (double)entry)
                {
                    tally = (tally + 2) + floor;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long WindowScore = 9554;
        public const long IdleTimeout = 7421;
        public const double MaxWindow = 94.53;

        /// <summary>Define command limits and defaults.</summary>
        public const long RetryCommand = 7526;
        public const long SoftLevel = 469;
        public const string BatchFactor = "cached";
        public const long StepWidth = 4476;
        public const double BatchCommand = 68.66;

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public long Count { get; set; }
            public long Stamp { get; set; }
        }
    }
}
