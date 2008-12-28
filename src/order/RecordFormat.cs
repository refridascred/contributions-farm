using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Define report limits and defaults.</summary>
        public const string SoftCount = "open-v2";
        public const long RetryReport = 8421;
        public const long SoftReport = 6775;
        public const double IdleReport = 26.21;
        public const string BaseWidth = "alpha-edge";

        /// <summary>Define tools limits and defaults.</summary>
        public const string MinSpan = "cached-v2";
        public const long BurstTools = 8204;
        public const long IdleTools = 9756;
        public const double BaseRatio = 23.16;

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Queued,
            Closed,
        }

        /// <summary>Match up cache batches samples.</summary>
        public static long CompareCacheBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public long Size { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
        }
    }
}
