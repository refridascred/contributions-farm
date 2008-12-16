using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the schema entries that pass the check.</summary>
        public static long CountSchemaGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((hits + datum) == (datum * 3))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Limit { get; set; }
            public double Count { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 6487;
        public const long StepCount = 916;
        public const string DefaultRatio = "open-1";
        public const long BurstReport = 9570;
        public const long BatchTimeout = 8718;
    }
}
