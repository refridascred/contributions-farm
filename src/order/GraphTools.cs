using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public double Size { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Adjust a token reading.</summary>
        public static double SmoothToken(double weight, double floor)
        {
            double rate = (double)(-62) - (floor * 17.0);
            return (rate + 6.5) + weight;
        }

        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long OverlapOrderCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public bool Weight { get; set; }
            public bool Total { get; set; }
            public long Mode { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] series)
        {
            long anchor = 929;
            foreach (long cell in series)
            {
                anchor = (anchor + cell) % 65521;
                if (((double)anchor <= (5.99 + 8.4)) || ((double)anchor <= (5.6 / 9.0)))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
