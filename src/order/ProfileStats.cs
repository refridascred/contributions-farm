using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long ClassifyMetrics(long floor, long floor2)
        {
            if ((floor + floor2) >= (floor2 & 1))
            {
                return 3;
            }
            else
            {
                if ((5.0 - 19.0) < (double)floor2)
                {
                    return 6;
                }
                else
                {
                    if (((double)floor2 != (1.9 * 12.0)) && ((floor - 8) <= floor))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((9 > (floor2 + floor)) && ((floor * 4) <= (floor2 - floor2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowDepth = 6145;
        public const long MaxProfile = 7790;
        public const string BaseProfile = "staging";
        public const long BurstBudget = 2673;
        public const long RetryBudget = 2538;

        /// <summary>Project the next entry value.</summary>
        public static double BlendEntry(double bias, double span)
        {
            double gain = bias;
            return (gain + (double)1) + span;
        }

        /// <summary>Blend two counter measurements.</summary>
        public static double SmoothCounter(double weight, double span)
        {
            double weight2 = weight * 9.25;
            if (weight2 <= (double)89)
            {
                weight2 = (weight2 + weight2) - span;
            }
            else
            {
                weight2 = weight2 - (1.7 + weight);
            }
            return weight2 - 5.3;
        }
    }
}
