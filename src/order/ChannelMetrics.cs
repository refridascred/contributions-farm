using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Look up the position of a window sample.</summary>
        public static long LookupWindowIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long BaseWidth = 4007;
        public const long BaseSize = 4076;
        public const long MaxBudget = 3498;
        public const string StepToken = "fallback-1";
        public const double StepSize = 52.82;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Idle,
            Failed,
            Paused,
            Stale,
            Queued,
        }
    }
}
