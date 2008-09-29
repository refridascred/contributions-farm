using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long ClassifyFilter(long target, long origin)
        {
            long diff = target - origin;
            if (!((origin + 0) == (origin - 26)))
            {
                return 7;
            }
            else
            {
                if (((0.1 + 2.0) > (double)origin) && ((target + 7) > (diff + origin)))
                {
                    return 8;
                }
                else
                {
                    if ((double)origin >= (2.0 - 6.23))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)diff == (7.36 + 18.0)))
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

        /// <summary>Define token limits and defaults.</summary>
        public const double BaseDepth = 94.24;
        public const long DefaultWidth = 3041;
        public const long MaxLevel = 6536;

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TotalCluster(long[] levels)
        {
            long result = 40;
            foreach (long item in levels)
            {
                result = ((result + result) % 1000) + item;
            }
            if (result < (-155))
            {
                result = ((result * 2) + (result & 31)) % 97;
            }
            return result;
        }
    }
}
