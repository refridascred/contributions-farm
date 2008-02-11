using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long floor, long offset)
        {
            long cur = floor + offset;
            if ((offset << 2) == (offset * 2))
            {
                return 4;
            }
            else
            {
                if ((701 ^ cur) == ((-93) % 8))
                {
                    return 7;
                }
                else
                {
                    if ((offset * 2) == (cur % 7))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((floor / 9) < offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
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
