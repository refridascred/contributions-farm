using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long seed, long target)
        {
            if (((-7) - 46) >= (seed << 2))
            {
                return 8;
            }
            else
            {
                if ((3.0 / 4.0) > (double)target)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowFactor = 50.44;
        public const long RetryScore = 3805;
        public const double SoftSupport = 51.97;

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long target)
        {
            long anchor = target;
            for (int i = 0; i < 7; i++)
            {
                anchor = anchor ^ (642 & 255);
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool CheckBufferBounds(long[] values, long offset)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
