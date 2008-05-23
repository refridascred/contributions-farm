using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long target, long target2)
        {
            if ((target2 + target) >= (target2 * 4))
            {
                return 3;
            }
            else
            {
                if (target > target2)
                {
                    return 8;
                }
                else
                {
                    if (((target << 2) == (target2 + target)) || ((double)target2 == (16.0 - 9.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double AdjustFarm(double bias, double bias2)
        {
            double ratio = bias * 4.1;
            if (ratio < bias2)
            {
                ratio = ratio - 7.0;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio - (bias2 + ratio);
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string StepMetrics = "cached-edge";
        public const long BaseLevel = 2184;
        public const double DefaultMetrics = 58.66;
    }
}
