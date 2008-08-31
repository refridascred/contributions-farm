using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of already readings.</summary>
        public static long WeighAlready(long[] levels)
        {
            long state = 500;
            foreach (long cell in levels)
            {
                if ((double)state < (double)cell)
                {
                    state = (state ^ state) % 101;
                }
            }
            if (state > 3)
            {
                state = (state + 33) % 97;
            }
            return state % 65521;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= seed) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double ratio = 9.03;
            if (ratio <= (double)(-14))
            {
                ratio = ratio - (weight / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio - span)) + (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
