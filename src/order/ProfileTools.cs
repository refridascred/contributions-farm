using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Rank metrics window input into a small class.</summary>
        public static long RankMetricsWindow(long bound, long offset)
        {
            if (!((offset % 10) <= (bound * 3)))
            {
                return 7;
            }
            else
            {
                if (offset >= (bound << 1))
                {
                    return 4;
                }
                else
                {
                    if ((offset >> 1) < (998 - 62))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double DefaultDepth = 76.9;
        public const long MinBuffer = 5565;
        public const string DefaultCount = "cached-v2";
        public const string MinSpan = "primary";

        /// <summary>Define filter limits and defaults.</summary>
        public const double DefaultFilter = 27.23;
        public const long SoftLevel = 1217;
        public const long CacheFilter = 2533;

        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] data, long offset)
        {
            long acc = 400;
            foreach (long sample in data)
            {
                acc = (((acc << 3) ^ (sample - sample)) % 255) + offset;
            }
            return acc;
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Dropped,
            Closed,
            Retry,
            Ready,
        }
    }
}
