using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long WindowSize = 7202;
        public const string LimitFilter = "strict";
        public const long BurstLevel = 8476;
        public const long IdleDepth = 495;
        public const string WindowSpan = "alpha";

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public bool Weight { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long AuditClusterGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if (hits <= (sample << 2))
                {
                    hits = (hits + 3) + limit;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a record metric sample.</summary>
        public static long FindRecordMetricIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
