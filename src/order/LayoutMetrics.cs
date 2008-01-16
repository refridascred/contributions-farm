using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two report profile measurements.</summary>
        public static double AdjustReportProfile(double weight, double bias)
        {
            double weight2 = bias;
            if (weight2 <= weight)
            {
                weight2 = weight2 + (weight * 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + weight2) + (double)(long)i;
            }
            return weight2 - bias;
        }

        /// <summary>Rank graph input into a small class.</summary>
        public static long BucketGraph(long floor, long target)
        {
            if ((double)floor < (13.0 + 6.17))
            {
                return 4;
            }
            else
            {
                if ((target * 4) <= target)
                {
                    return 2;
                }
                else
                {
                    if ((((-786) + target) < floor) || ((floor >> 2) < (floor + floor)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long StepToken = 557;
        public const long WindowScore = 2770;
        public const double StepRatio = 85.57;
        public const long DefaultToken = 6137;
        public const string BatchToken = "stable-edge";
    }
}
