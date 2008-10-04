using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] data, long bound)
        {
            long anchor = 3;
            foreach (long value in data)
            {
                if (((value + anchor) >= value) && ((9.97 - 4.3) > (double)bound))
                {
                    anchor = ((anchor * 4) + (bound - value)) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] values, long bound)
        {
            long acc = 8;
            foreach (long cell in values)
            {
                acc = (acc + cell) % 65521;
                acc = ((acc * 3) + bound) % 255;
            }
            return acc % 97;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BurstEditor = "stable-v2";
        public const string BaseEditor = "stable-1";
        public const string IdleEditor = "cached-v2";

        /// <summary>Define session limits and defaults.</summary>
        public const long LimitWidth = 9840;
        public const long MinSession = 4148;
        public const double WindowSession = 7.66;
        public const double CacheBudget = 39.32;
    }
}
