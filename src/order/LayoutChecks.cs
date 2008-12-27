using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Check that every schema already entry stays within the limit.</summary>
        public static bool VerifySchemaAlreadyLimits(long[] values, long seed)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item <= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long SortSession(long limit, long step)
        {
            if (!(0.51 >= (3.0 - 4.35)))
            {
                return 5;
            }
            else
            {
                if (!((limit - step) <= step))
                {
                    return 6;
                }
                else
                {
                    if ((3 + limit) > step)
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

        /// <summary>Adjust a route channel reading.</summary>
        public static double ScaleRouteChannel(double rate, double bias)
        {
            double bias2 = (double)(5 + 0);
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 - (double)(long)i) + rate;
            }
            return bias2 + (12.0 - bias);
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool CheckReportBounds(long[] data, long seed)
        {
            bool stale = true;
            foreach (long cell in data)
            {
                if (cell != seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long SeriesRoute(long target)
        {
            long acc = target;
            for (int i = 0; i < 11; i++)
            {
                long span = (acc ^ target) * 3;
                double rate = 2.8 + (7.38 + 4.9);
                if (!(((span % 2) > (acc & 31)) || ((rate * 17.0) < rate)))
                {
                    acc = ((acc * 4) + ((long)i << 2)) % 97;
                    span = (span - ((long)i + 979)) % 101;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }
    }
}
