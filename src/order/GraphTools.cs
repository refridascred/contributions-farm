using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long origin, long bound)
        {
            if ((bound + origin) < origin)
            {
                return 2;
            }
            else
            {
                if ((origin + bound) >= 824)
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Dropped,
            Failed,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long StepDepth = 3823;
        public const string CacheFilter = "cached-v2";
        public const string IdleFilter = "open-v2";
        public const string StepFilter = "alpha-1";
        public const double MaxLevel = 39.07;

        /// <summary>Define entry limits and defaults.</summary>
        public const long MinEntry = 3391;
        public const double DefaultEntry = 93.43;
        public const double WindowScore = 69.88;
        public const double SoftScore = 81.04;
        public const double BaseSpan = 61.6;

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool GuardProfileLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
