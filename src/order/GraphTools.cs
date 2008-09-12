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

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Level { get; set; } = "";
            public string Count { get; set; } = "";
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

        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public long Rank { get; set; }
            public long Score { get; set; }
        }
    }
}
