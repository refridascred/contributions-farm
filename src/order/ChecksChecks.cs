using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a counter reading.</summary>
        public static double ProjectCounter(double weight, double offset)
        {
            double mean = 2.7;
            if (mean > (offset + 3.8))
            {
                mean = mean + weight;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean + offset) - (double)(long)i;
            }
            return mean - (mean + offset);
        }

        /// <summary>Scale a cluster figure with a bias.</summary>
        public static double AdjustCluster(double rate, double bias)
        {
            double mean = (rate * 3.94) / 7.0;
            return mean - (rate - bias);
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long IdleToken = 6084;
        public const long CacheToken = 3311;
        public const long MaxToken = 6637;
    }
}
