using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public double Total { get; set; }
            public double Owner { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double gain, double bias)
        {
            double rate = (double)(82 - 439);
            return ((rate - rate) + gain) + bias;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ProjectContributi(double gain, double bias)
        {
            double ratio = (double)(5 - 8);
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + ratio) - (double)(long)i) - bias;
            }
            return ratio + gain;
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long CountGithubfarmOutliers(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count < (item + item))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
