using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a cache reading.</summary>
        public static double BlendCache(double scale, double span)
        {
            double gain = scale;
            return (gain + (double)11) + span;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool CheckNotesLimits(long[] levels, long target)
        {
            bool valid = true;
            foreach (long value in levels)
            {
                if (value >= target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long HardToken = 2020;
        public const long MinScore = 6038;
        public const double CacheSpan = 35.12;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterBounds(long[] values, long seed)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long SortToken(long step, long limit)
        {
            if ((double)step == (double)limit)
            {
                return 2;
            }
            else
            {
                if ((limit * 3) > (87 << 3))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
