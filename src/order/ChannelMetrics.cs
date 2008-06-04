using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Retry,
            Done,
            Active,
            Failed,
            Dropped,
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Limit { get; set; }
            public double Level { get; set; }
        }
    }
}
