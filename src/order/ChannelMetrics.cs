using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Scale a batch order figure with a bias.</summary>
        public static double ProjectBatchOrder(double bias, double floor)
        {
            double mean = floor + (floor - 9.74);
            if (mean <= (double)(-232))
            {
                mean = mean + bias;
            }
            return mean - (floor + mean);
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] values, long origin)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate githubfarm batch readings against a bound.</summary>
        public static bool VerifyGithubfarmBatchLimits(long[] data, long step)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
