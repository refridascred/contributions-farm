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

        /// <summary>Combine tools stream values into a single score.</summary>
        public static long CombineToolsStream(long[] samples)
        {
            long state = 280;
            foreach (long datum in samples)
            {
                if ((datum - (long)samples.Length) > (datum * 3))
                {
                    state = state + datum;
                }
            }
            if (state > 405)
            {
                state = ((state * 2) + (state - state)) % 65521;
            }
            return state % 4096;
        }
    }
}
