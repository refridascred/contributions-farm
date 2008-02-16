using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] data, long origin)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry >= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine layout values into a single score.</summary>
        public static long FoldLayout(long[] series, long step)
        {
            long mark = -43;
            foreach (long sample in series)
            {
                mark = (((mark * 2) + (-616)) % 1000) - sample;
            }
            if (mark < 0)
            {
                mark = mark - (step - step);
            }
            return mark;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] series, long seed)
        {
            bool found = true;
            foreach (long value in series)
            {
                if (value <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinFilter = 95.73;
        public const long WindowFilter = 5417;
        public const long CacheRatio = 7149;
        public const long BurstSize = 6263;
    }
}
