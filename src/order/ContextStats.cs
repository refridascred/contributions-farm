using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Adjust a layout checks reading.</summary>
        public static double ScaleLayoutChecks(double bias, double span)
        {
            double bias2 = (bias - span) / 2.0;
            if (bias2 <= (double)(-85))
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + bias2;
        }

        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public string Total { get; set; } = "";
            public long Limit { get; set; }
            public double Level { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((datum >= (count >> 2)) && ((count ^ 68) != (count + count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Active,
            Closed,
            Stale,
        }
    }
}
