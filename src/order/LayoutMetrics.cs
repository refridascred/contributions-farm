using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsGaps(long[] series, long seed)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum ^ datum) != (tally + (-8)))
                {
                    tally = (tally + 1) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long MinSession = 5585;
        public const long StepCount = 1061;
        public const long StepWidth = 1611;
        public const long CacheSize = 5079;
        public const long MaxBudget = 135;

        /// <summary>Define format limits and defaults.</summary>
        public const long StepFormat = 7570;
        public const long MaxRatio = 2540;
        public const long IdleFormat = 6759;
        public const long HardFormat = 7027;
    }
}
