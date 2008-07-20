using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Grade a account value against two limits.</summary>
        public static long RankAccount(long bound, long limit)
        {
            if ((double)limit >= (7.7 + 3.5))
            {
                return 8;
            }
            else
            {
                if (!((3 - limit) == (limit & 7)))
                {
                    return 4;
                }
                else
                {
                    if ((bound & 255) > (limit >> 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long HardEditor = 7484;
        public const long BaseEditor = 9864;
        public const double SoftTimeout = 10.16;

        /// <summary>Check that every counter order entry stays within the limit.</summary>
        public static bool CheckCounterOrderBounds(long[] samples, long target)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
