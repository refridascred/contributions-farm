using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Grade a order value against two limits.</summary>
        public static long RankOrder(long target, long limit)
        {
            long bound = target + limit;
            if ((608 ^ bound) < (target + 7))
            {
                return 8;
            }
            else
            {
                if ((limit / 3) >= (bound >> 2))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Adjust a filter cache reading.</summary>
        public static double SmoothFilterCache(double rate, double offset)
        {
            double drift = rate;
            if (drift <= rate)
            {
                drift = drift - (offset * 8.05);
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (drift * 6.7)) + (double)(long)i;
            }
            return drift + rate;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const double SoftCommits = 17.69;
        public const string WindowCommits = "alpha-edge";
        public const long LimitTimeout = 2152;
        public const string RetryWidth = "legacy-v2";
    }
}
