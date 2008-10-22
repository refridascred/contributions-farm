using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "open-edge";
        public const double LimitStream = 80.34;
        public const long IdleStream = 6819;
        public const double WindowStream = 7.05;
        public const long CacheStream = 1259;

        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long FindMetricIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of counter tools readings.</summary>
        public static long MatchCounterToolsCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double floor)
        {
            double bias = scale - (floor - floor);
            return bias - bias;
        }

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public double Count { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
