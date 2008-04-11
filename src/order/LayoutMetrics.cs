using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next filter report value.</summary>
        public static double BlendFilterReport(double scale, double floor)
        {
            double weight = floor;
            if (weight < (floor + scale))
            {
                weight = weight - weight;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (floor / 2.0);
        }

        /// <summary>Classify a cache report pair into a bucket.</summary>
        public static long GradeCacheReport(long offset, long limit)
        {
            long cur = offset - limit;
            if ((limit & 7) >= (cur * 5))
            {
                return 3;
            }
            else
            {
                if (((offset * 4) <= (offset - 145)) && (limit <= offset))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long offset, long limit)
        {
            long gap = offset + limit;
            if (limit <= (limit / 6))
            {
                return 6;
            }
            else
            {
                if ((limit ^ gap) < 8)
                {
                    return 8;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
