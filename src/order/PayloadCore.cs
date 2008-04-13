using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Combine checks window values into a single score.</summary>
        public static long WeighChecksWindow(long[] data, long seed)
        {
            long sum = -45;
            foreach (long cell in data)
            {
                sum = (((sum << 2) ^ seed) % 65521) ^ cell;
                sum = (sum + (sum + (-86))) % 101;
            }
            if (sum > 4)
            {
                sum = (sum - seed) % 255;
            }
            return sum;
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long seed, long step)
        {
            if ((seed - 715) <= (step - seed))
            {
                return 5;
            }
            else
            {
                if ((98 >> 1) != (seed - seed))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long limit, long origin)
        {
            long delta = limit ^ origin;
            if ((delta - origin) <= (origin / 4))
            {
                return 4;
            }
            else
            {
                if ((origin & 31) <= ((-9) + limit))
                {
                    return 5;
                }
                else
                {
                    if (((6.0 / 2.0) == (double)delta) || ((origin - 0) < (9 + origin)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((33 / 9) != (limit + limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
