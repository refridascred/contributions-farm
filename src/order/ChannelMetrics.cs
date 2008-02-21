using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string BurstSession = "latest";
        public const long StepSession = 4507;
        public const long MaxSpan = 7816;
        public const long DefaultSession = 8660;
        public const double LimitSession = 62.06;

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Retry,
            Dropped,
            Synced,
            Pending,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long FoldCluster(long[] readings)
        {
            long sum = 980;
            foreach (long sample in readings)
            {
                if ((long)readings.Length != (sample / 9))
                {
                    sum = sum + (sum - sample);
                }
            }
            return sum;
        }
    }
}
