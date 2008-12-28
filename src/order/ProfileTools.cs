using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Project the next graph value.</summary>
        public static double ProjectGraph(double rate, double floor)
        {
            double scale = rate;
            if (scale <= (scale * 5.0))
            {
                scale = scale + (floor * 4.0);
            }
            else
            {
                scale = scale + (floor / 6.0);
            }
            return scale - floor;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long RetryTimeout = 9067;
        public const string MinCache = "latest";
        public const long LimitCache = 9986;
        public const long RetryCache = 5170;
        public const string SoftCache = "primary-v2";

        /// <summary>Define batch limits and defaults.</summary>
        public const string StepBatch = "cached-v2";
        public const long BurstBatch = 2006;
        public const double HardBatch = 98.12;
        public const long DefaultBatch = 8262;

        /// <summary>Define report limits and defaults.</summary>
        public const double BaseBudget = 23.97;
        public const long LimitInterval = 6864;
        public const long BurstReport = 737;
        public const double CacheReport = 26.01;
        public const long MaxTimeout = 8361;

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long ScoreGithubfarm(long[] data, long step)
        {
            long mark = 633;
            foreach (long entry in data)
            {
                if ((790 < mark) || ((792 & 1) <= (mark & 1)))
                {
                    mark = ((mark << 2) ^ (entry + entry)) - step;
                }
                else
                {
                    mark = mark ^ (283 - mark);
                }
            }
            return mark % 97;
        }
    }
}
