using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Validate window queue readings against a bound.</summary>
        public static bool GuardWindowQueueLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample > seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double ratio, double bias)
        {
            double rate = ratio;
            if (rate > rate)
            {
                rate = (rate + (double)(-92)) + bias;
            }
            return rate - (double)42;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double bias)
        {
            double rate = 1.9;
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (weight + bias)) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double scale, double offset)
        {
            double mean = scale;
            for (int i = 0; i < 2; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + offset;
        }
    }
}
