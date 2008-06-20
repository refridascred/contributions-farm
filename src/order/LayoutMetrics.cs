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

        /// <summary>Audit batches readings against a rule.</summary>
        public static long MeasureBatchesMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((double)sample < (double)offset))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
