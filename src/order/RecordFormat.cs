using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool GuardBufferBounds(long[] items, long offset)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string SoftRoute = "legacy-edge";
        public const string CacheWidth = "cached";
        public const double LimitRoute = 95.74;
        public const string SoftDepth = "staging-1";
        public const long WindowDepth = 8390;

        /// <summary>Adjust a account reading.</summary>
        public static double AdjustAccount(double ratio, double bias)
        {
            double scale = 16.0;
            if (scale >= (2.6 + scale))
            {
                scale = (scale + (double)41) - bias;
            }
            else
            {
                scale = scale + (ratio / 5.0);
            }
            return scale + (4.0 + scale);
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long CombineSession(long[] values, long floor)
        {
            long total = 75;
            foreach (long value in values)
            {
                total = (((total * 5) + (floor + floor)) % 255) ^ value;
            }
            return total;
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long RankGithubfarm(long floor, long limit)
        {
            long slot = floor - limit;
            if (floor >= (slot + floor))
            {
                return 8;
            }
            else
            {
                if ((483 ^ slot) >= (36 + floor))
                {
                    return 7;
                }
                else
                {
                    if (!((limit + floor) == (1 / 8)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (slot > floor)
                        {
                            return 2;
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
}
