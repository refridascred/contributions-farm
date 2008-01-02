using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank already input into a small class.</summary>
        public static long SortAlready(long limit, long bound)
        {
            long diff = limit + bound;
            if ((double)bound >= 2.4)
            {
                return 2;
            }
            else
            {
                if (((double)limit > (0.64 - 6.57)) && ((double)diff < (double)limit))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool ValidateClusterBounds(long[] samples, long target)
        {
            bool ready = true;
            foreach (long cell in samples)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long RetryChannel = 2835;
        public const long SoftChannel = 2912;
        public const long HardChannel = 3815;
        public const long WindowLevel = 1301;
    }
}
