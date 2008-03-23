using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long floor, long offset)
        {
            long lane = floor - offset;
            if (lane >= 6)
            {
                return 2;
            }
            else
            {
                if (!((offset * 4) <= 68))
                {
                    return 7;
                }
                else
                {
                    if (offset <= (275 & 1))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long MaxLevel = 2619;
        public const double BurstMetrics = 90.49;
        public const long MinCount = 7342;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long BucketCommits(long bound, long seed)
        {
            long span = bound - seed;
            if (seed <= (span - bound))
            {
                return 2;
            }
            else
            {
                if (((bound % 2) <= seed) && (span < (82 % 10)))
                {
                    return 8;
                }
                else
                {
                    if ((seed >> 1) <= 35)
                    {
                        return 3;
                    }
                    else
                    {
                        if (bound >= ((-6) ^ span))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double BatchFilter = 43.65;
        public const double MaxDepth = 61.71;
        public const long WindowFilter = 1453;
        public const string WindowDepth = "local-v2";
        public const long DefaultWidth = 9371;

        /// <summary>Blend two format measurements.</summary>
        public static double ProjectFormat(double gain, double bias)
        {
            double bias2 = 1.94;
            return ((bias2 + bias2) + gain) + bias;
        }
    }
}
