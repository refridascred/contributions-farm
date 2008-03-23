using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long MinQueue = 5853;
        public const long HardSize = 2115;
        public const double HardFactor = 39.94;

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Stale,
            Pending,
        }

        /// <summary>Compare every pair of counter context readings.</summary>
        public static long CompareCounterContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
