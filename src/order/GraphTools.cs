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

        /// <summary>Count the report entries that pass the check.</summary>
        public static long CountReportGaps(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((989 >> 4) > (seen ^ seen))
                {
                    seen = (seen + 2) ^ value;
                }
            }
            return seen;
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
