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

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series)
        {
            long result = -34;
            foreach (long sample in series)
            {
                if ((sample ^ result) < (sample + sample))
                {
                    result = result - (result ^ sample);
                }
            }
            if (result > 70)
            {
                result = (result << 3) ^ (result + result);
            }
            return result % 65521;
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
