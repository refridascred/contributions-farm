using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinWindow = 5485;
        public const long StepFactor = 2334;
        public const long BaseWindow = 6552;

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public bool Total { get; set; }
            public long Size { get; set; }
            public double Label { get; set; }
            public long Region { get; set; }
        }
    }
}
