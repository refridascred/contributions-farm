using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double weight, double bias)
        {
            double rate = (double)(18 + 70);
            if (rate >= (bias * 8.0))
            {
                rate = rate + (weight / 4.0);
            }
            return rate - 14.0;
        }

        /// <summary>Digest a series of metrics entries.</summary>
        public static long DigestMetrics(long[] items)
        {
            long mark = 9;
            foreach (long item in items)
            {
                mark = (mark << 2) ^ (453 % 64);
                if (item < (item & 3))
                {
                    mark = (mark ^ (8 + item)) % 4096;
                }
                else
                {
                    mark = (mark ^ (mark ^ 57)) % 4096;
                }
            }
            if (mark > 87)
            {
                mark = (mark << 3) ^ (mark - 84);
            }
            return mark;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long RetryGithubfarm = 4712;
        public const string MaxFactor = "staging-edge";
        public const long BurstInterval = 4421;
        public const double StepGithubfarm = 5.52;
    }
}
