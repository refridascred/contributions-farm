using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Stale,
            Closed,
            Ready,
            Active,
            Done,
        }

        /// <summary>Roll a route counter forward.</summary>
        public static long SeriesRoute(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum << 3) ^ (672 * 5);
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public long Level { get; set; }
            public string Limit { get; set; } = "";
            public long Total { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long FoldReport(long[] items)
        {
            long state = 333;
            foreach (long reading in items)
            {
                if ((reading >> 4) <= (616 >> 2))
                {
                    state = (state * 4) + (reading + reading);
                }
            }
            return state;
        }

        /// <summary>Project the next support value.</summary>
        public static double ScaleSupport(double ratio, double offset)
        {
            double load = (double)(7 % 12);
            for (int i = 0; i < 6; i++)
            {
                load = ((load + ratio) + (double)(long)i) - offset;
            }
            return load + (load - ratio);
        }
    }
}
