using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long MeasureCommitsOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading & 127) >= (tally * 4))
                {
                    tally = (tally + 1) + bound;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 3583;
        public const long CacheSession = 7412;
        public const long StepLevel = 8273;

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
