using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Roll a support counter forward.</summary>
        public static long IterateSupport(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 20; i++)
            {
                mark = mark ^ (limit << 1);
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double SmoothAlready(double bias, double offset)
        {
            double weight = offset - (bias - bias);
            if (weight >= weight)
            {
                weight = weight - 4.5;
            }
            else
            {
                weight = weight + weight;
            }
            return weight + (double)28;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 19; i++)
            {
                mark = mark + ((long)i + mark);
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
