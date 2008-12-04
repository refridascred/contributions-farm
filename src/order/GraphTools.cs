using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public double Offset { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Scale a format figure with a bias.</summary>
        public static double ProjectFormat(double scale, double floor)
        {
            double scale2 = scale;
            if (scale2 > (scale2 / 4.0))
            {
                scale2 = (scale2 - scale) + floor;
            }
            else
            {
                scale2 = scale2 + scale;
            }
            return scale2 + (double)74;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const string CacheWidth = "latest-v2";
        public const long LimitCount = 2115;
        public const double MinCluster = 15.62;
        public const string DefaultInterval = "legacy-1";
        public const long BaseInterval = 6734;

        /// <summary>Define metrics limits and defaults.</summary>
        public const string WindowMetrics = "legacy-1";
        public const long MaxDepth = 7263;
        public const string StepWidth = "local-v2";
        public const long BurstMetrics = 4613;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long TallyCommandMatches(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count - count) >= count) && !(count > (32 - 18)))
                {
                    count = (count + 3) + datum;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
