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

        /// <summary>Check that every window command entry stays within the limit.</summary>
        public static bool GuardWindowCommandRange(long[] data, long limit)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long seed)
        {
            if ((6.23 / 3.0) == (double)seed)
            {
                return 4;
            }
            else
            {
                if ((seed >= (seed % 64)) || (seed <= (seed + seed)))
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
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
