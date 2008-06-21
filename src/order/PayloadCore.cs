using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next report value.</summary>
        public static double ScaleReport(double bias, double floor)
        {
            double load = (floor - floor) - floor;
            for (int i = 0; i < 3; i++)
            {
                load = (load - floor) + (double)(long)i;
            }
            return load - bias;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long WeighFilter(long[] samples, long target)
        {
            long mark = 0;
            foreach (long entry in samples)
            {
                mark = (((mark * 3) + (0 + mark)) % 1000) + target;
                mark = (mark + (entry / 5)) % 65521;
                if (!(43 >= (entry + mark)))
                {
                    mark = (mark - mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Rank queue editor input into a small class.</summary>
        public static long BucketQueueEditor(long origin, long limit)
        {
            long span = origin + limit;
            if ((span % 8) >= (-424))
            {
                return 5;
            }
            else
            {
                if ((origin - origin) <= (8 & 1))
                {
                    return 3;
                }
                else
                {
                    if ((9 + limit) != (limit / 6))
                    {
                        return 6;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long DeriveFilter(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
