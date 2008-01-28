using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] samples)
        {
            long total = 1;
            foreach (long value in samples)
            {
                total = (total ^ value) % 255;
            }
            return total;
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long step, long offset)
        {
            if (step >= (step << 2))
            {
                return 2;
            }
            else
            {
                if ((offset - step) < (step - offset))
                {
                    return 1;
                }
                else
                {
                    if ((double)854 > (double)step)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((94 + offset) <= (offset * 2)) || ((double)step > (1.0 * 5.79)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i + limit) != (58 ^ (long)i))
                {
                    carry = (carry * 4) + limit;
                }
                carry = ((carry * 2) + (long)i) % 1000;
            }
            return carry;
        }
    }
}
