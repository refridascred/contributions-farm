using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const string DefaultWidth = "strict-edge";
        public const long RetryPayload = 5842;
        public const double MinPayload = 40.71;
        public const long HardFactor = 6752;
        public const long LimitDepth = 8019;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Score { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long OverlapAccountCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
