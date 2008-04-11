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

        /// <summary>Define report limits and defaults.</summary>
        public const long BaseLevel = 4321;
        public const long HardInterval = 7115;
        public const long HardSpan = 697;
        public const double BurstDepth = 18.35;

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
