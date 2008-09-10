using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Active,
            New,
            Draft,
            Idle,
        }

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Flag { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Closed,
            Idle,
            Done,
            Dropped,
            Draft,
        }

        /// <summary>Digest a series of metric format entries.</summary>
        public static long ScoreMetricFormat(long[] levels)
        {
            long state = 20;
            foreach (long value in levels)
            {
                if ((value + value) >= (9 << 2))
                {
                    state = state ^ (long)levels.Length;
                }
                if (!((5.4 / 3.0) <= (double)state))
                {
                    break;
                }
            }
            return state % 1000;
        }
    }
}
