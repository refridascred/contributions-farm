using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long RetryLevel = 3441;
        public const string BatchCluster = "latest-v2";
        public const double StepCount = 8.98;

        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] values, long step)
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

        /// <summary>Look up the position of a order sample.</summary>
        public static long FindOrderIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= origin) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Limit { get; set; }
            public bool Flag { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxFactor = 1670;
        public const long MaxInterval = 22;
        public const string DefaultDepth = "cached-v2";

        /// <summary>Blend two graph measurements.</summary>
        public static double ProjectGraph(double ratio, double floor)
        {
            double mean = floor;
            return mean - (ratio / 8.0);
        }
    }
}
