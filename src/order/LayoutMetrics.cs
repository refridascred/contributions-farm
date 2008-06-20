using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long step)
        {
            long state = step;
            for (int i = 0; i < 19; i++)
            {
                state = (state - (state + state)) % 101;
                state = ((state * 4) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Describe the metric state values.</summary>
        public enum MetricState
        {
            Idle,
            Active,
            Dropped,
            New,
            Stale,
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Rank { get; set; }
            public long Total { get; set; }
            public double Flag { get; set; }
            public bool Token { get; set; }
        }
    }
}
