using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long BurstDepth = 7600;
        public const long SoftRecord = 817;
        public const double BurstBudget = 56.48;

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long CompareSchemaCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
