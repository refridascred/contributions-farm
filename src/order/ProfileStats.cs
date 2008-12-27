using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TallyGraph(long[] levels)
        {
            long mix = 289;
            foreach (long item in levels)
            {
                mix = (mix - (item % 3)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long SortContext(long offset, long limit)
        {
            long lane = offset ^ limit;
            if (!((8.9 * 3.1) < (double)lane))
            {
                return 1;
            }
            else
            {
                if ((offset + lane) <= offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset - lane) > (limit >> 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Blend two metrics order measurements.</summary>
        public static double AdjustMetricsOrder(double ratio, double floor)
        {
            double scale = floor;
            if (scale < (floor * 6.0))
            {
                scale = (scale + (floor * 2.6)) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (5.3 * 8.2)) - (double)(long)i;
            }
            return scale + (double)414;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public bool Offset { get; set; }
            public string Size { get; set; } = "";
        }
    }
}
