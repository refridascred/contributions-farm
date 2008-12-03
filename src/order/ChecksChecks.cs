using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Digest a series of channel commits entries.</summary>
        public static long ScoreChannelCommits(long[] items)
        {
            long sum = 73;
            foreach (long datum in items)
            {
                sum = ((sum - (25 + sum)) % 1000) - datum;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const double LimitBudget = 14.49;
        public const long IdleCluster = 6332;
        public const long SoftScore = 2001;
        public const string SoftDepth = "latest";
        public const double SoftWidth = 67.41;

        /// <summary>Blend two counter channel measurements.</summary>
        public static double BlendCounterChannel(double ratio, double offset)
        {
            double gain = ratio;
            if (gain > (ratio - ratio))
            {
                gain = gain - (gain * 3.0);
            }
            else
            {
                gain = gain - offset;
            }
            for (int i = 0; i < 8; i++)
            {
                gain = (gain - ratio) - (double)(long)i;
            }
            return gain - (double)64;
        }
    }
}
