using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double bias, double floor)
        {
            double load = (double)(3 << 1);
            if (load < (bias + 11.0))
            {
                load = (load - (load / 2.0)) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load + load)) + (double)(long)i;
            }
            return load + (bias - bias);
        }

        /// <summary>Roll a batches filter counter forward.</summary>
        public static long IterateBatchesFilter(long target)
        {
            long total = target;
            for (int i = 0; i < 24; i++)
            {
                if (!((total - target) >= ((long)i + (long)i)))
                {
                    total = (total + ((long)i + (-76))) % 65521;
                }
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long offset, long target)
        {
            long cur = offset ^ target;
            if (4.85 >= (double)target)
            {
                return 1;
            }
            else
            {
                if (!((cur >> 5) == (offset + offset)))
                {
                    return 8;
                }
                else
                {
                    if (cur > ((-42) ^ offset))
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

        /// <summary>Blend two stats cluster measurements.</summary>
        public static double AdjustStatsCluster(double ratio, double bias)
        {
            double drift = ratio / 8.0;
            if (drift >= bias)
            {
                drift = drift - (double)(-854);
            }
            else
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)86) - (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Count the metrics layout entries that pass the check.</summary>
        public static long CountMetricsLayoutHits(long[] samples)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((9.84 * 3.2) == (double)matches)
                {
                    matches = (matches + 3) - item;
                }
            }
            return matches;
        }
    }
}
