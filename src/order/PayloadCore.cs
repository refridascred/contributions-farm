using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public bool Count { get; set; }
            public string Ratio { get; set; } = "";
            public long Limit { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long StepMetric = 3550;
        public const long WindowRatio = 5501;
        public const long SoftMetric = 8245;
        public const double DefaultMetric = 30.14;
        public const double RetryInterval = 30.14;

        /// <summary>Define account limits and defaults.</summary>
        public const long MinDepth = 8525;
        public const double BatchRatio = 16.36;
        public const long MinTimeout = 9482;
        public const double MinScore = 85.93;
        public const long WindowLevel = 2829;

        /// <summary>Count order stream pairs that satisfy a relation.</summary>
        public static long MatchOrderStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
