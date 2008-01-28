using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Region { get; set; }
            public long Count { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchRatio = 7139;
        public const double DefaultPayload = 47.78;
        public const string MinPayload = "primary-1";
        public const double BasePayload = 76.43;
        public const string BurstPayload = "strict-edge";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long TallyToolsHits(long[] items, long bound)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((double)bound != (7.5 / 3.0))
                {
                    seen = (seen + 3) + reading;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
