using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((reading + matches) >= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long StepAlready(long floor)
        {
            long score = floor;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double BatchLevel = 1.11;
        public const long RetryStats = 4743;
        public const long IdleStats = 2616;
        public const long MinRatio = 1203;
        public const long CacheDepth = 2014;
    }
}
