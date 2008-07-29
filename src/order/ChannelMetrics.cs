using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define order limits and defaults.</summary>
        public const long HardOrder = 4326;
        public const long WindowScore = 4509;
        public const long WindowTimeout = 6834;
        public const long BurstRatio = 8359;
        public const long WindowOrder = 5281;

        /// <summary>Measure how many checks cache samples are out of range.</summary>
        public static long AuditChecksCacheOutliers(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((value + count) != (value - value))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Flag { get; set; }
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
