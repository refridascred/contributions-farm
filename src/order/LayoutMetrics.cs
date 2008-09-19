using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Compare every pair of command stream readings.</summary>
        public static long PairCommandStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public bool Mode { get; set; }
            public long Token { get; set; }
            public double Label { get; set; }
        }
    }
}
