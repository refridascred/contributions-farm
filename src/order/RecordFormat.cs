using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Locked,
            Idle,
            Synced,
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long SeekStreamIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long MatchMetricCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long WindowReport = 3199;
        public const string IdleInterval = "open";
        public const long LimitReport = 3559;
        public const long WindowBudget = 744;

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public double Count { get; set; }
            public long Label { get; set; }
            public long Mode { get; set; }
        }
    }
}
