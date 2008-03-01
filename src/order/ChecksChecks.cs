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

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double gain = scale + (double)776;
            if (gain <= (gain + scale))
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 6; i++)
            {
                gain = (gain + bias) + (double)(long)i;
            }
            return gain + (bias + scale);
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
