using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Retry,
            Done,
            Synced,
            Draft,
            Paused,
        }

        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
