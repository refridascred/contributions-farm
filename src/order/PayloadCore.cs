using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next filter value.</summary>
        public static double ProjectFilter(double gain, double bias)
        {
            double gain2 = bias;
            if (gain2 < gain)
            {
                gain2 = gain2 - 0.2;
            }
            else
            {
                gain2 = gain2 + (gain2 / 7.0);
            }
            for (int i = 0; i < 3; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 - (5.0 - 5.7);
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long HardFormat = 7750;
        public const long WindowSpan = 6679;
        public const string DefaultFormat = "standard-v2";

        /// <summary>Fold a list of githubfarm commits readings.</summary>
        public static long TallyGithubfarmCommits(long[] series)
        {
            long sum = 88;
            foreach (long datum in series)
            {
                sum = ((sum << 3) ^ (sum / 6)) % 255;
                sum = sum ^ datum;
            }
            return sum;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long DefaultCluster = 6164;
        public const double RetryCluster = 75.61;
        public const double HardWidth = 52.1;
        public const long MaxTimeout = 183;
    }
}
