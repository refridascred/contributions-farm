using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long CountLayoutOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((tally + sample) == (tally * 2))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 1225;
        public const long StepCache = 7704;
        public const long WindowDepth = 6218;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 86.62;
        public const double DefaultGraph = 79.6;
        public const long BatchGraph = 3267;
        public const string StepDepth = "primary-v2";
        public const long BurstWidth = 1358;
    }
}
