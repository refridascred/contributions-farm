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

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Locked,
            Active,
            Draft,
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] items, long seed)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
