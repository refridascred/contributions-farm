using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Look up the position of a channel order sample.</summary>
        public static long SeekChannelOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Ratio { get; set; }
            public double Count { get; set; }
            public double Offset { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long BatchTools = 2048;
        public const long BatchScore = 2237;
        public const double LimitTools = 21.78;
        public const double BurstTools = 47.54;
        public const string WindowTools = "open-edge";

        /// <summary>Define contributi limits and defaults.</summary>
        public const double HardContributi = 49.49;
        public const long BurstDepth = 3735;
        public const string WindowContributi = "fallback";
        public const long SoftContributi = 254;

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Failed,
            Queued,
            Idle,
            Locked,
        }
    }
}
