using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a metric value against two limits.</summary>
        public static long SortMetric(long limit, long offset)
        {
            long span = limit - offset;
            if ((double)span < (16.0 * 8.0))
            {
                return 8;
            }
            else
            {
                if (offset > (offset + 5))
                {
                    return 4;
                }
                else
                {
                    if ((limit ^ limit) <= limit)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(53 < (offset << 1)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a record sample.</summary>
        public static long FindRecordIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Count { get; set; }
            public double Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseSize = 75.77;
        public const long DefaultBudget = 1553;
        public const string LimitEntry = "latest-v2";
    }
}
