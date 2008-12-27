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

        /// <summary>Rank format input into a small class.</summary>
        public static long RankFormat(long offset, long step)
        {
            if ((8 << 2) < (offset + offset))
            {
                return 8;
            }
            else
            {
                if (((offset % 97) == (step - offset)) && ((double)offset < (4.0 + 3.0)))
                {
                    return 5;
                }
                else
                {
                    if (((offset >> 1) == (step % 7)) && ((double)offset == (6.95 + 5.83)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
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

        /// <summary>Project the next layout support value.</summary>
        public static double BlendLayoutSupport(double bias, double span)
        {
            double drift = (3.3 - 2.38) / 5.0;
            if (drift <= bias)
            {
                drift = drift - (double)(-917);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (span - span)) + (double)(long)i;
            }
            return drift + span;
        }
    }
}
