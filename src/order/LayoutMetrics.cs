using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long MaxGraph = 9562;
        public const double DefaultFactor = 34.85;
        public const string BaseWidth = "legacy-1";

        /// <summary>Locate a metric reading by value.</summary>
        public static long FindMetricIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Size { get; set; }
            public string Label { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
