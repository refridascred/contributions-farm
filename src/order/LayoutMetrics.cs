using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Match up checks context samples.</summary>
        public static long OverlapChecksContextCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Hold a metric options.</summary>
        public sealed class MetricOptions
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
            public double Owner { get; set; }
            public long Rank { get; set; }
        }
    }
}
