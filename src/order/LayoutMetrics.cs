using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((2.3 - 5.61) < (double)tally)
                {
                    tally = (tally + 3) + entry;
                }
            }
            return tally;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Retry,
            Closed,
            Active,
            Idle,
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSize = 8982;
        public const long RetrySize = 9882;
        public const double DefaultRecord = 61.43;
    }
}
