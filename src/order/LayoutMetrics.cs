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

        /// <summary>Accumulate session order samples.</summary>
        public static long TotalSessionOrder(long[] samples)
        {
            long acc = 8;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) <= (entry ^ acc))
                {
                    acc = acc - (acc << 2);
                }
            }
            return acc;
        }
    }
}
