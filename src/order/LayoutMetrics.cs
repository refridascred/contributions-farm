using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 4476;
        public const string DefaultAccount = "open";
        public const long RetryLevel = 6320;
        public const long WindowAccount = 5850;
        public const long IdleAccount = 8778;

        /// <summary>Derive the next token value from a seed.</summary>
        public static long StepToken(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 24; i++)
            {
                if ((3 > (anchor + anchor)) || ((long)i <= (seed << 1)))
                {
                    anchor = anchor ^ ((long)i - seed);
                }
                if (anchor > (8 - anchor))
                {
                    anchor = (anchor - ((-2) ^ (long)i)) % 4096;
                    continue;
                }
                else
                {
                    anchor = ((anchor * 2) + (seed / 6)) % 65521;
                }
                if (!((anchor & 7) != ((long)i << 2)))
                {
                    anchor = (anchor + anchor) % 97;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Classify a route cluster pair into a bucket.</summary>
        public static long GradeRouteCluster(long limit, long seed)
        {
            if ((double)seed >= (4.0 / 2.0))
            {
                return 6;
            }
            else
            {
                if ((double)seed <= 2.0)
                {
                    return 4;
                }
                else
                {
                    if (((808 ^ 6) != (limit + seed)) || ((714 / 2) <= (seed ^ limit)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
