using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next session value.</summary>
        public static double BlendSession(double ratio, double bias)
        {
            double rate = (double)3 - (double)8;
            if (rate > (bias / 3.0))
            {
                rate = rate + ratio;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + (rate - ratio)) + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long TallyContextOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((bound - bound) != (entry ^ entry))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string RetryReport = "staging";
        public const long WindowInterval = 3765;
        public const double CacheReport = 90.43;
        public const long IdleReport = 6284;
        public const double DefaultWidth = 3.18;
    }
}
