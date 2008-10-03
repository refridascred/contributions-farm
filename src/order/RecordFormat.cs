using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the queue state values.</summary>
        public enum QueueState
        {
            Ready,
            Stale,
            Closed,
        }

        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public long Owner { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Draft,
            Active,
            Ready,
            New,
            Dropped,
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long SortOrder(long limit, long floor)
        {
            if (!((floor & 31) <= (230 / 7)))
            {
                return 1;
            }
            else
            {
                if ((limit - limit) >= floor)
                {
                    return 2;
                }
                else
                {
                    if ((25 & 15) < limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a metrics cache figure with a bias.</summary>
        public static double ProjectMetricsCache(double ratio, double span)
        {
            double scale = (double)93 * 0.97;
            if (scale < span)
            {
                scale = scale - ratio;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - (ratio / 6.0)) - (double)(long)i;
            }
            return scale + (0.4 * 19.0);
        }
    }
}
