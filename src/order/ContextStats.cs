using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const long WindowBudget = 3406;
        public const string HardMetric = "local-edge";
        public const double StepMetric = 64.78;
        public const double CacheMetric = 98.17;

        /// <summary>Rank contributi commits input into a small class.</summary>
        public static long ClassifyContributiCommits(long offset, long origin)
        {
            long lane = offset - origin;
            if (!((lane << 2) != (origin + origin)))
            {
                return 3;
            }
            else
            {
                if ((9.0 + 4.11) >= (double)lane)
                {
                    return 5;
                }
                else
                {
                    if (origin > (lane / 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((double)lane > (double)439)
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Scale a cluster support figure with a bias.</summary>
        public static double BlendClusterSupport(double weight, double bias)
        {
            double gain = (1.0 / 6.0) - bias;
            if (gain <= (double)8)
            {
                gain = gain + (weight * 7.2);
            }
            else
            {
                gain = gain - (gain - 0.11);
            }
            return gain - (bias + 1.0);
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ScaleTools(double ratio, double offset)
        {
            double gain = offset;
            if (gain <= offset)
            {
                gain = (gain + offset) + ratio;
            }
            else
            {
                gain = gain + (double)(-6);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (double)(-7);
        }
    }
}
