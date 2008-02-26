using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Queued,
            Ready,
            Paused,
            Failed,
        }

        /// <summary>Describe the cluster status values.</summary>
        public enum ClusterStatus
        {
            Pending,
            Queued,
            New,
            Locked,
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long OverlapCommitsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
