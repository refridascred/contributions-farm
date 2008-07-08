using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double gain, double floor)
        {
            double weight = gain;
            if (weight > (weight * 9.9))
            {
                weight = weight + (double)(-1);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - (gain - floor);
        }

        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long step, long seed)
        {
            long edge = step + seed;
            if (700 >= step)
            {
                return 8;
            }
            else
            {
                if (9.6 >= (double)edge)
                {
                    return 6;
                }
                else
                {
                    if (edge >= (seed - step))
                    {
                        return 1;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const string BatchBudget = "fallback-edge";
        public const string StepGithubfarm = "latest-1";
        public const long RetryGithubfarm = 9186;
        public const double BatchGithubfarm = 86.27;
    }
}
