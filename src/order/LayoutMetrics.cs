using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long BucketAccount(long offset, long limit)
        {
            if ((limit % 16) == (1 & 127))
            {
                return 0;
            }
            else
            {
                if ((offset * 5) >= (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if (((-1) + limit) < limit)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((8.0 / 2.0) >= (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long LimitCache = 1225;
        public const long StepCache = 7704;
        public const long WindowDepth = 6218;

        /// <summary>Define graph limits and defaults.</summary>
        public const double MinGraph = 86.62;
        public const double DefaultGraph = 79.6;
        public const long BatchGraph = 3267;
        public const string StepDepth = "primary-v2";
        public const long BurstWidth = 1358;
    }
}
