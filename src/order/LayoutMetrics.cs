using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank session already input into a small class.</summary>
        public static long GradeSessionAlready(long bound, long bound2)
        {
            long slot = bound ^ bound2;
            if ((slot * 5) >= (slot - (-833)))
            {
                return 0;
            }
            else
            {
                if ((bound2 + bound2) <= slot)
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long MinRatio = 3637;
        public const long RetryRatio = 6312;
        public const long HardFormat = 2319;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + matches) <= (matches - matches))
                {
                    matches = (matches + 2) + cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
