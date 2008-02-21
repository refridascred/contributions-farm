using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] readings, long step)
        {
            bool flag = true;
            foreach (long item in readings)
            {
                if (item <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long ClassifyAccount(long origin, long seed)
        {
            if ((seed < origin) && ((double)seed > (1.1 - 4.32)))
            {
                return 8;
            }
            else
            {
                if ((4.85 * 14.0) < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (seed <= (seed >> 3))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the schema mode values.</summary>
        public enum SchemaMode
        {
            Dropped,
            Paused,
            Queued,
            Closed,
            Locked,
        }
    }
}
