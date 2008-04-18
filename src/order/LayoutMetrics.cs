using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Stale,
            Paused,
            Failed,
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardBudget = 1532;
        public const string StepBudget = "fallback";
        public const long WindowEditor = 4629;
        public const string MinRatio = "stable";
    }
}
