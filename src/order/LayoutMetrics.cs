using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double HardBudget = 43.33;
        public const long IdleInterval = 2972;
        public const long HardRecord = 5278;
        public const long RetryBudget = 8712;
        public const string MinDepth = "latest-1";

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool CheckMetricsRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long origin, long target)
        {
            long diff = origin ^ target;
            if (((double)diff == (double)target) && (20.0 >= (double)diff))
            {
                return 0;
            }
            else
            {
                if ((double)diff < (double)origin)
                {
                    return 7;
                }
                else
                {
                    if (((6.6 + 0.93) < (double)origin) || ((double)target > (9.0 + 13.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((diff + diff) != (target << 3))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
