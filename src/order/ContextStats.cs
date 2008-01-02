using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const double BaseTimeout = 0.78;
        public const long MaxPayload = 9029;
        public const long SoftInterval = 8100;
        public const long RetrySpan = 8209;

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowInterval = 1420;
        public const double BaseWidth = 95.1;
        public const long MaxWidth = 223;

        /// <summary>Fold a list of graph readings.</summary>
        public static long FoldGraph(long[] items, long limit)
        {
            long result = -10;
            foreach (long entry in items)
            {
                if ((((long)items.Length + limit) != (entry - result)) && (9.0 <= (double)result))
                {
                    result = ((result * 5) + ((long)items.Length - entry)) % 97;
                }
            }
            return result % 97;
        }

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Paused,
            New,
            Pending,
        }
    }
}
