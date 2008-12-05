using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Combine metrics context values into a single score.</summary>
        public static long WeighMetricsContext(long[] samples)
        {
            long sum = 27;
            foreach (long datum in samples)
            {
                if (datum > sum)
                {
                    sum = ((sum * 2) + (3 + sum)) % 4096;
                }
                sum = sum ^ (datum * 2);
            }
            return sum % 65521;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long bound, long origin)
        {
            if (((bound % 2) > (bound + bound)) || ((bound - 475) != (origin + bound)))
            {
                return 4;
            }
            else
            {
                if ((double)origin > 5.6)
                {
                    return 1;
                }
                else
                {
                    if (!((double)origin <= 17.0))
                    {
                        return 5;
                    }
                    else
                    {
                        if (bound > (bound + 5))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 3816;
        public const long DefaultBudget = 7251;
        public const long HardBudget = 8872;
        public const long RetryRoute = 7323;
        public const long IdleRoute = 6597;

        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] values)
        {
            long acc = 6;
            foreach (long item in values)
            {
                acc = (acc + (item - acc)) % 101;
                if ((8 << 1) >= (acc - acc))
                {
                    break;
                }
            }
            return acc % 65521;
        }
    }
}
