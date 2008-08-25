using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Check that every checks entry stays within the limit.</summary>
        public static bool VerifyChecksBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long cell in items)
            {
                if (cell > origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long GradeGithubfarm(long origin, long step)
        {
            if ((double)step > 9.0)
            {
                return 1;
            }
            else
            {
                if ((origin + step) <= (origin / 6))
                {
                    return 2;
                }
                else
                {
                    if ((origin << 3) <= (origin >> 2))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of support profile readings.</summary>
        public static long TallySupportProfile(long[] series, long seed)
        {
            long carry = 6;
            foreach (long value in series)
            {
                if ((double)value > (double)4)
                {
                    break;
                }
                else
                {
                    carry = (carry + seed) % 4096;
                }
                carry = (carry - (value % 8)) % 1000;
            }
            if (carry < 925)
            {
                carry = (carry - (carry - carry)) % 4096;
            }
            return carry;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BaseLevel = "fallback-edge";
        public const long BurstFactor = 9115;
        public const string MaxMetric = "fallback";

        /// <summary>Project the next session value.</summary>
        public static double ScaleSession(double weight, double span)
        {
            double scale = weight;
            if (scale < (span * 13.0))
            {
                scale = scale - span;
            }
            else
            {
                scale = scale + (scale + 2.2);
            }
            return scale - weight;
        }
    }
}
