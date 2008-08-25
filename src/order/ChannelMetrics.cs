using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueBounds(long[] series, long origin)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next filter value.</summary>
        public static double BlendFilter(double bias, double offset)
        {
            double weight = (double)(272 + (-67));
            if (weight >= (double)3)
            {
                weight = (weight + (18.0 + offset)) + bias;
            }
            return weight - (9.8 / 9.0);
        }

        /// <summary>Grade a layout githubfarm value against two limits.</summary>
        public static long SortLayoutGithubfarm(long seed, long seed2)
        {
            long diff = seed ^ seed2;
            if ((double)seed2 > (6.39 / 2.0))
            {
                return 5;
            }
            else
            {
                if ((diff >> 2) <= (diff / 7))
                {
                    return 1;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
