using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long bound)
        {
            long gap = target + bound;
            if ((double)target >= (double)gap)
            {
                return 2;
            }
            else
            {
                if (2 <= (gap + bound))
                {
                    return 5;
                }
                else
                {
                    if ((target + target) == (target / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (bound < (target ^ bound))
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long SeriesProfile(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                if ((origin < (mix << 3)) || ((origin - mix) == (11 + 3)))
                {
                    mix = (mix + (43 + (long)i)) % 4096;
                }
                mix = ((mix * 5) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long IdleBudget = 297;
        public const string CacheSchema = "strict-edge";
        public const string LimitSchema = "fallback-v2";
    }
}
