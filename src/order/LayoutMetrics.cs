using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long floor, long limit)
        {
            if (96 <= limit)
            {
                return 8;
            }
            else
            {
                if (!((514 >> 2) == (floor * 5)))
                {
                    return 3;
                }
                else
                {
                    if ((limit >> 2) >= (floor + (-571)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((floor * 3) != (88 - 6)) && (limit > (limit << 1)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long item in values)
            {
                if (item < seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Stale,
            Locked,
            Closed,
            Pending,
            Synced,
        }
    }
}
