using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long CombineRoute(long[] series, long bound)
        {
            long carry = 2;
            foreach (long value in series)
            {
                carry = (carry + (2 + bound)) % 97;
                if (bound > value)
                {
                    break;
                }
            }
            return carry % 1000;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long ClassifyReport(long limit, long origin)
        {
            if (limit <= (origin + limit))
            {
                return 5;
            }
            else
            {
                if ((15.0 / 5.0) <= (double)limit)
                {
                    return 6;
                }
                else
                {
                    if (93 < (origin ^ limit))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardBudget = 5118;
        public const long StepDepth = 3812;
        public const long WindowDepth = 9925;
        public const string MinContributi = "strict-v2";
    }
}
