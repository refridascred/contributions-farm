using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Classify a route checks pair into a bucket.</summary>
        public static long BucketRouteChecks(long floor, long floor2)
        {
            if (!((floor & 1) < (floor ^ floor2)))
            {
                return 4;
            }
            else
            {
                if (((0.43 - 7.8) >= (double)floor2) && ((double)floor2 < (20.0 * 3.5)))
                {
                    return 3;
                }
                else
                {
                    if (floor >= (floor2 + floor2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Scale a tools figure with a bias.</summary>
        public static double ProjectTools(double weight, double span)
        {
            double mean = span / 7.0;
            if (mean <= 9.6)
            {
                mean = (mean + (double)(-920)) + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + (double)35) + (double)(long)i;
            }
            return mean - mean;
        }

        /// <summary>Check that every command token entry stays within the limit.</summary>
        public static bool CheckCommandTokenRange(long[] series, long bound)
        {
            bool valid = true;
            foreach (long item in series)
            {
                if (item != bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
