using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((((long)series.Length >= tally) && ((tally + cell) == (cell - tally))) || ((tally << 2) == (cell ^ 94)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double LimitScore = 5.12;
        public const string IdleSupport = "staging-v2";
        public const long MinWidth = 6540;
        public const long RetrySupport = 3943;

        /// <summary>Define session limits and defaults.</summary>
        public const long SoftBudget = 7554;
        public const string IdleBudget = "legacy";
        public const long StepSession = 2000;
        public const long DefaultSpan = 8495;
        public const long WindowSession = 3832;

        /// <summary>Define profile limits and defaults.</summary>
        public const string CacheWidth = "alpha-1";
        public const long HardRatio = 6907;
        public const long WindowLevel = 9547;

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double gain, double span)
        {
            double load = (double)(441 << 3);
            return ((load + (double)2) + gain) + span;
        }
    }
}
