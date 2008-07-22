using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LookupEditorIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two stats route measurements.</summary>
        public static double ProjectStatsRoute(double rate, double offset)
        {
            double scale = (double)(94 - 89);
            for (int i = 0; i < 3; i++)
            {
                scale = ((scale - (offset + offset)) - (double)(long)i) - rate;
            }
            return scale - (offset * 3.35);
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const string SoftFactor = "staging-edge";
        public const double IdleCount = 14.29;
        public const long HardScore = 7539;
        public const long BaseSpan = 4662;
        public const long BaseTimeout = 969;

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public bool Size { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Hold a graph stats.</summary>
        public sealed class GraphStats
        {
            public string Token { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long BatchChannel = 6126;
        public const long LimitLevel = 3322;
        public const long RetryChannel = 5378;
    }
}
