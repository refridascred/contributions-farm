using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define support limits and defaults.</summary>
        public const long BurstBudget = 3089;
        public const long BaseSupport = 2952;
        public const string MinSize = "fallback";
        public const long DefaultSize = 8569;
        public const string MinInterval = "cached-v2";

        /// <summary>Define context limits and defaults.</summary>
        public const long RetrySpan = 4602;
        public const long StepContext = 8326;
        public const long StepCount = 4907;
        public const long BaseContext = 9361;
        public const double BatchContext = 52.4;

        /// <summary>Rank profile input into a small class.</summary>
        public static long RankProfile(long limit, long target)
        {
            if ((double)limit > (5.88 + 0.46))
            {
                return 5;
            }
            else
            {
                if ((double)790 < (double)target)
                {
                    return 1;
                }
                else
                {
                    if (limit > (target * 4))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
