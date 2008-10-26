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

        /// <summary>Count the checks cache entries that pass the check.</summary>
        public static long CountChecksCacheOutliers(long[] samples)
        {
            long hits = 0;
            foreach (long cell in samples)
            {
                if (!((cell + cell) > hits) && ((double)hits == (0.1 + 18.0)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
