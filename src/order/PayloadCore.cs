using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of batch layout readings.</summary>
        public static long OverlapBatchLayoutCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel phase values.</summary>
        public enum ChannelPhase
        {
            Pending,
            New,
            Dropped,
            Closed,
            Paused,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Pending,
            Synced,
            Ready,
            Idle,
        }

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            New,
            Locked,
            Dropped,
            Paused,
        }
    }
}
