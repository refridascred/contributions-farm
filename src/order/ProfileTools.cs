using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long LimitGraph = 285;
        public const string MaxTimeout = "local-1";
        public const long CacheGraph = 2544;
        public const string BatchGraph = "fallback-edge";
        public const long MaxGraph = 8746;

        /// <summary>Adjust a queue reading.</summary>
        public static double ProjectQueue(double weight, double span)
        {
            double scale = weight;
            if (scale > (double)(-81))
            {
                scale = (scale + 9.2) + span;
            }
            else
            {
                scale = scale - weight;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + weight) - (double)(long)i;
            }
            return scale + (4.29 / 2.0);
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long BaseRecord = 2568;
        public const long RetrySpan = 1835;
        public const long BurstTimeout = 1234;
        public const double MaxRecord = 94.74;
        public const long MinRecord = 2833;

        /// <summary>Check that every checks profile entry stays within the limit.</summary>
        public static bool ValidateChecksProfileBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long SeekAlreadyIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
