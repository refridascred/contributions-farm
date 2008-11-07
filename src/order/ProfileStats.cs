using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long bound, long seed)
        {
            long lane = bound + seed;
            if ((bound < seed) && ((lane + (-19)) < seed))
            {
                return 3;
            }
            else
            {
                if (((575 >> 5) < (lane * 5)) && ((lane << 2) > bound))
                {
                    return 1;
                }
                else
                {
                    if ((471 ^ bound) > bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Adjust a metric reading.</summary>
        public static double ScaleMetric(double scale, double bias)
        {
            double drift = scale;
            if (drift > bias)
            {
                drift = drift - (2.1 + bias);
            }
            else
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift - scale;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long CombineContext(long[] data, long step)
        {
            long mark = 34;
            foreach (long item in data)
            {
                mark = (mark - (step + item)) % 101;
            }
            if (mark < 20)
            {
                mark = (mark << 2) ^ (step << 2);
            }
            return mark % 1000;
        }
    }
}
