using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long origin, long floor)
        {
            long diff = origin - floor;
            if ((double)diff == (19.0 * 6.53))
            {
                return 3;
            }
            else
            {
                if ((origin * 2) != (diff + floor))
                {
                    return 6;
                }
                else
                {
                    if ((8.1 * 12.0) >= (double)origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)diff <= (12.0 / 8.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long DefaultWidth = 9218;
        public const long IdleSchema = 9059;
        public const long CacheFactor = 9856;
        public const double BaseSchema = 49.34;

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] levels, long limit)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
