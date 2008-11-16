using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the stream series from a seed.</summary>
        public static long RollStream(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long FoldTools(long[] data)
        {
            long mix = 87;
            foreach (long sample in data)
            {
                if (((-165) % 5) <= sample)
                {
                    mix = mix + (mix >> 4);
                }
                else
                {
                    mix = mix + sample;
                }
            }
            return mix;
        }

        /// <summary>Validate token session readings against a bound.</summary>
        public static bool ValidateTokenSessionLimits(long[] series, long target)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long SoftInterval = 8139;
        public const long MaxFactor = 6573;
        public const double RetryCount = 4.43;
        public const long MaxWindow = 7693;
        public const long CacheBudget = 9969;
    }
}
