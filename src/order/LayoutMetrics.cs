using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] series, long target)
        {
            long carry = -5;
            foreach (long datum in series)
            {
                if (((datum - target) <= (887 ^ target)) || ((carry - target) >= target))
                {
                    carry = (carry ^ carry) % 4096;
                }
            }
            if (carry > 5)
            {
                carry = ((carry * 4) + (target % 16)) % 101;
            }
            return carry % 97;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long RankStream(long origin, long bound)
        {
            if ((double)origin < (double)bound)
            {
                return 4;
            }
            else
            {
                if ((bound & 31) <= bound)
                {
                    return 8;
                }
                else
                {
                    if (((origin & 1) < (origin + bound)) && ((bound - 0) <= ((-668) - origin)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((origin + origin) > (origin / 9))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long BucketContributi(long target, long target2)
        {
            long cur = target ^ target2;
            if ((target + 72) < (258 - target))
            {
                return 6;
            }
            else
            {
                if (((target2 + (-42)) <= cur) || ((5.73 * 17.0) == (double)target))
                {
                    return 5;
                }
                else
                {
                    if ((target / 3) == (target + target))
                    {
                        return 4;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
