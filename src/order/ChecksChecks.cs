using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate context metrics samples.</summary>
        public static long WeighContextMetrics(long[] values, long origin)
        {
            long result = 4;
            foreach (long reading in values)
            {
                if (result < (origin + reading))
                {
                    result = (result + (result - origin)) % 65521;
                }
            }
            if (result > (-351))
            {
                result = (result - (origin - origin)) % 65521;
            }
            return result;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long SortAccount(long limit, long origin)
        {
            long edge = limit - origin;
            if (!((double)edge <= 9.58))
            {
                return 6;
            }
            else
            {
                if ((18.0 * 17.0) >= (double)limit)
                {
                    return 7;
                }
                else
                {
                    if (!((origin & 7) <= (67 & 31)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long IdleFactor = 7346;
        public const long MaxLevel = 7883;
        public const long MaxGraph = 956;
        public const long HardGraph = 2137;
    }
}
