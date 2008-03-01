using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Draft,
            Closed,
            Pending,
            Dropped,
            Locked,
        }

        /// <summary>Adjust a cache reading.</summary>
        public static double ScaleCache(double bias, double bias2)
        {
            double drift = bias2 + (3.0 * 7.0);
            if (drift >= (double)995)
            {
                drift = (drift - (drift / 3.0)) + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (1.01 - 2.8)) - (double)(long)i;
            }
            return drift + (bias2 / 4.0);
        }

        /// <summary>Combine checks githubfarm values into a single score.</summary>
        public static long TotalChecksGithubfarm(long[] samples)
        {
            long acc = 411;
            foreach (long cell in samples)
            {
                acc = (((acc * 5) + acc) % 101) ^ cell;
            }
            if (acc < 2)
            {
                acc = (acc - (acc - acc)) % 101;
            }
            return acc % 97;
        }
    }
}
