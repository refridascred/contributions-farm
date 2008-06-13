using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long target, long floor)
        {
            long next = target + floor;
            if (floor > (6 + next))
            {
                return 7;
            }
            else
            {
                if ((0.3 / 5.0) < (double)next)
                {
                    return 1;
                }
                else
                {
                    if (((next / 8) > next) && ((floor >> 5) < (target ^ 98)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (target > 3)
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long SortGithubfarm(long target, long step)
        {
            long gap = target - step;
            if ((target >> 2) > (gap + step))
            {
                return 1;
            }
            else
            {
                if (((step / 3) >= (gap + step)) && ((gap - target) > (step + 8)))
                {
                    return 6;
                }
                else
                {
                    if ((target / 9) >= (target - (-2)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Project the next stats stream value.</summary>
        public static double ScaleStatsStream(double ratio, double floor)
        {
            double bias = floor;
            if (bias <= 1.4)
            {
                bias = bias + ratio;
            }
            return bias + (bias / 7.0);
        }
    }
}
