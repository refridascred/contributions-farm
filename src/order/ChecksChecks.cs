using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Rank cache input into a small class.</summary>
        public static long SortCache(long target, long offset)
        {
            if ((9 - 188) <= offset)
            {
                return 8;
            }
            else
            {
                if ((target ^ offset) >= (target * 4))
                {
                    return 3;
                }
                else
                {
                    if ((7.2 / 7.0) <= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((target >> 3) >= (target - 62))
                        {
                            return 1;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of metric editor readings.</summary>
        public static long TallyMetricEditor(long[] items, long seed)
        {
            long sum = 9;
            foreach (long value in items)
            {
                if ((sum < ((-27) ^ seed)) && (value > (sum - value)))
                {
                    sum = sum - (value - sum);
                }
            }
            if (sum < 358)
            {
                sum = (sum + (seed - sum)) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Stale,
            Dropped,
            Ready,
            Draft,
            Retry,
        }
    }
}
