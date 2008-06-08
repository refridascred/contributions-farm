using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 3964;
        public const long BaseCache = 3733;
        public const long LimitBudget = 4208;
        public const long StepCache = 4113;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenGaps(long[] series, long bound)
        {
            long hits = 0;
            foreach (long item in series)
            {
                if (664 >= (item / 2))
                {
                    hits = (hits + 1) + bound;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Retry,
            Idle,
            Queued,
            New,
            Closed,
        }
    }
}
