using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long CacheWidth = 7647;
        public const long MaxChecks = 7979;
        public const string SoftChecks = "latest-1";
        public const long DefaultChecks = 6396;
        public const long LimitChecks = 8773;

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 1811;
        public const string CacheSize = "stable-edge";
        public const long WindowDepth = 3373;
        public const string BatchQueue = "fallback";
        public const long WindowQueue = 9566;

        /// <summary>Derive the next already value from a seed.</summary>
        public static long RollAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix * 2) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
