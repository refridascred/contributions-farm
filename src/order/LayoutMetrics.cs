using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Rank layout input into a small class.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            if (!(offset < (offset + bound)))
            {
                return 2;
            }
            else
            {
                if ((offset >> 1) <= (bound % 5))
                {
                    return 4;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long RetryDepth = 1104;
        public const double LimitRatio = 53.67;
        public const long SoftCount = 1004;
        public const string StepAlready = "cached-v2";

        /// <summary>Scale a order figure with a bias.</summary>
        public static double BlendOrder(double gain, double span)
        {
            double ratio = (double)234 + gain;
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio + (gain + gain);
        }
    }
}
