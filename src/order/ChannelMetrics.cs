using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long CacheSize = 9758;
        public const long CacheWidth = 4870;
        public const long DefaultInterval = 1753;
        public const double MaxAlready = 10.61;

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double SmoothQueue(double weight, double floor)
        {
            double load = floor;
            if (load > 18.0)
            {
                load = (load + 2.34) + weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = (load + (load / 3.0)) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long ClassifyCluster(long limit, long target)
        {
            long delta = limit - target;
            if ((272 * 3) > (target >> 4))
            {
                return 5;
            }
            else
            {
                if ((10.0 * 1.2) < (double)limit)
                {
                    return 3;
                }
                else
                {
                    if ((2.0 + 9.34) <= (double)target)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((target - delta) >= target)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
