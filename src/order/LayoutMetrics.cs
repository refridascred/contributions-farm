using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Adjust a tools graph reading.</summary>
        public static double ProjectToolsGraph(double weight, double floor)
        {
            double scale = weight;
            if (scale < weight)
            {
                scale = scale + (4.0 * 14.0);
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + (floor - scale)) + (double)(long)i;
            }
            return scale - (double)582;
        }

        /// <summary>Classify a order entry pair into a bucket.</summary>
        public static long RankOrderEntry(long limit, long seed)
        {
            if ((double)limit == (0.1 - 7.8))
            {
                return 3;
            }
            else
            {
                if (((double)seed >= (4.5 - 6.4)) && ((limit + seed) != (seed + seed)))
                {
                    return 5;
                }
                else
                {
                    if (!((limit ^ limit) >= seed))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
