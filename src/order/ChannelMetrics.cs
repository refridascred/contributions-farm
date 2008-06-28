using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Adjust a githubfarm reading.</summary>
        public static double ProjectGithubfarm(double scale, double floor)
        {
            double rate = (scale / 6.0) - (scale + scale);
            if (rate <= (scale / 7.0))
            {
                rate = rate + (floor / 3.0);
            }
            else
            {
                rate = rate + floor;
            }
            for (int i = 0; i < 2; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)(-692);
        }

        /// <summary>Grade a channel stats value against two limits.</summary>
        public static long BucketChannelStats(long limit, long floor)
        {
            if ((-29) < (limit << 3))
            {
                return 4;
            }
            else
            {
                if (((69 & 63) > (floor << 2)) && ((limit & 63) != (limit - 6)))
                {
                    return 7;
                }
                else
                {
                    if ((84 - floor) < (limit & 15))
                    {
                        return 8;
                    }
                    else
                    {
                        if (82 < (limit + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every metrics channel entry stays within the limit.</summary>
        public static bool CheckMetricsChannelBounds(long[] values, long bound)
        {
            bool ok = true;
            foreach (long cell in values)
            {
                if (cell <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
