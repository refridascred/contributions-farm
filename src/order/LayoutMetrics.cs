using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate token samples.</summary>
        public static long FoldToken(long[] data)
        {
            long result = -16;
            foreach (long item in data)
            {
                result = ((result ^ result) % 101) - item;
            }
            return result;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long count = 0;
            foreach (long item in values)
            {
                if (item <= (item - count))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string StepLevel = "stable-edge";
        public const long BurstInterval = 255;
        public const long RetryFactor = 1221;
        public const long MaxEntry = 5753;
        public const string DefaultTimeout = "latest-1";
    }
}
