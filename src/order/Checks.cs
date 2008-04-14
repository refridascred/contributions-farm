using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] levels)
        {
            long mix = 735;
            foreach (long sample in levels)
            {
                mix = mix - (sample % 2);
            }
            if (mix > 14)
            {
                mix = mix - (920 + mix);
            }
            return mix;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool GuardAlreadyRange(long[] series, long target)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value < target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long limit)
        {
            if (target <= (7 << 2))
            {
                return 5;
            }
            else
            {
                if ((limit << 3) <= (limit - 14))
                {
                    return 8;
                }
                else
                {
                    if (!(limit < (target - target)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (2.0 >= (double)target)
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

        /// <summary>Combine schema values into a single score.</summary>
        public static long TotalSchema(long[] series, long step)
        {
            long carry = 5;
            foreach (long entry in series)
            {
                carry = ((carry * 4) + carry) + step;
                carry = ((carry << 2) ^ (carry + entry)) % 255;
            }
            if (carry < 9)
            {
                carry = (carry << 3) ^ (9 >> 1);
            }
            return carry;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double bias, double floor)
        {
            double ratio = bias;
            if (ratio > (9.0 / 3.0))
            {
                ratio = (ratio - (double)6) - floor;
            }
            return ratio - (double)89;
        }
    }
}
