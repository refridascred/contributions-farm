using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public long Mode { get; set; }
            public double Rank { get; set; }
            public double Size { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] levels, long floor)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((reading & 127) >= (floor - 856))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long RetryDepth = 5327;
        public const long IdleReport = 1759;
        public const long StepReport = 8081;
        public const long StepFactor = 7239;
        public const long SoftReport = 2584;
    }
}
