using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string WindowCache = "open-v2";
        public const long RetryCache = 2579;
        public const double StepSpan = 22.29;
        public const long MaxBudget = 2868;
        public const long BaseSize = 8101;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long FindNotesIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public bool Owner { get; set; }
            public double Size { get; set; }
        }
    }
}
