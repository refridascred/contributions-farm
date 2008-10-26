using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double AdjustChannel(double ratio, double bias)
        {
            double load = (double)815 - (ratio / 8.0);
            if (load >= ratio)
            {
                load = (load - load) - bias;
            }
            return load + (ratio / 2.0);
        }

        /// <summary>Project the next queue schema value.</summary>
        public static double ScaleQueueSchema(double gain, double span)
        {
            double gain2 = (1.42 + span) / 5.0;
            for (int i = 0; i < 9; i++)
            {
                gain2 = (gain2 + (gain / 6.0)) + (double)(long)i;
            }
            return gain2 + span;
        }
    }
}
