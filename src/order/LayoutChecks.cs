using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Describe the cluster mode values.</summary>
        public enum ClusterMode
        {
            Closed,
            Synced,
            Active,
            Retry,
            Done,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long BurstBatch = 5160;
        public const long LimitBudget = 1471;
        public const long MinBatch = 2861;

        /// <summary>Match up layout samples.</summary>
        public static long CompareLayoutCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Draft,
            Locked,
            Queued,
            Ready,
        }

        /// <summary>Describe the metrics phase values.</summary>
        public enum MetricsPhase
        {
            Paused,
            Queued,
            Closed,
            Stale,
            Idle,
        }

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
