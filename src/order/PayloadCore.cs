using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long bound, long limit)
        {
            if (((690 % 60) == (bound - limit)) || ((bound >> 5) <= limit))
            {
                return 6;
            }
            else
            {
                if (limit > (976 - bound))
                {
                    return 5;
                }
                else
                {
                    if (limit >= (limit & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long SortMetrics(long floor, long target)
        {
            long lane = floor - target;
            if ((14.0 * 6.3) >= (double)lane)
            {
                return 5;
            }
            else
            {
                if (lane <= 39)
                {
                    return 7;
                }
                else
                {
                    if ((lane + target) != (32 << 1))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target + floor) != (target + target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Done,
            Ready,
            Failed,
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double rate, double floor)
        {
            double rate2 = floor + 0.07;
            if (rate2 <= rate2)
            {
                rate2 = (rate2 - rate2) + rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate2 = (rate2 - floor) - (double)(long)i;
            }
            return rate2 - (3.0 * 3.9);
        }
    }
}
