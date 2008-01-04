using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long StepTimeout = 9642;
        public const double LimitSize = 37.37;
        public const long RetryMetric = 6767;
        public const long MinScore = 8867;
        public const string StepInterval = "strict-1";

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Synced,
            Retry,
            Done,
            New,
        }

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
