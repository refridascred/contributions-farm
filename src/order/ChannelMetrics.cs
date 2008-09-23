using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define commits limits and defaults.</summary>
        public const long BatchFactor = 5681;
        public const long BurstCommits = 6602;
        public const long LimitBudget = 9951;
        public const long SoftRatio = 306;

        /// <summary>Match up stats entry samples.</summary>
        public static long CompareStatsEntryCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Closed,
            Dropped,
            Ready,
            Locked,
            Retry,
        }
    }
}
