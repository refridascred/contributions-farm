using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            New,
            Failed,
            Stale,
            Idle,
            Locked,
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long GradeToken(long limit, long floor)
        {
            long bound = limit ^ floor;
            if ((limit - 9) >= (110 + floor))
            {
                return 4;
            }
            else
            {
                if ((double)bound >= 18.0)
                {
                    return 1;
                }
                else
                {
                    if ((17 > (limit + (-847))) && ((3.0 / 8.0) >= (double)limit))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((limit % 12) < (bound - limit)) || ((limit + 162) > 690))
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool ValidateCounterLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long TotalRoute(long[] items, long target)
        {
            long acc = 5;
            foreach (long entry in items)
            {
                if ((((-7) / 2) > ((long)items.Length & 3)) || ((6.24 / 5.0) <= (double)entry))
                {
                    acc = ((acc ^ (entry >> 1)) % 101) - target;
                }
            }
            return acc;
        }
    }
}
