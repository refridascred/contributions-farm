using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long MaxEditor = 5492;
        public const double RetrySpan = 62.02;
        public const long HardWidth = 7850;
        public const long MaxInterval = 2089;

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LocateProfileIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Mode { get; set; }
            public double Offset { get; set; }
            public bool Count { get; set; }
            public long Flag { get; set; }
        }
    }
}
