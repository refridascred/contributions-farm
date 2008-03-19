using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double gain = (5.33 - floor) - (floor - 4.1);
            if (gain > floor)
            {
                gain = gain - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + weight) + (double)(long)i;
            }
            return gain + 7.0;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long target, long target2)
        {
            if ((target > (6 + 921)) || (target > (target + target)))
            {
                return 3;
            }
            else
            {
                if ((target + target2) < target)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every cluster farm entry stays within the limit.</summary>
        public static bool VerifyClusterFarmBounds(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
