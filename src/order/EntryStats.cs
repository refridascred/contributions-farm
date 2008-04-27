using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Pending,
            Ready,
            Idle,
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

        /// <summary>Blend two support batches measurements.</summary>
        public static double ScaleSupportBatches(double bias, double offset)
        {
            double drift = offset + (double)5;
            if (drift >= (double)(-18))
            {
                drift = drift - (9.5 * 14.0);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (drift - bias)) - (double)(long)i;
            }
            return drift + (bias + offset);
        }
    }
}
