using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 >= (double)5)
            {
                bias2 = bias2 - rate;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (rate / 3.0)) + (double)(long)i;
            }
            return bias2 - rate;
        }

        /// <summary>Look up the position of a report payload sample.</summary>
        public static long LocateReportPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a cluster value against two limits.</summary>
        public static long BucketCluster(long bound, long limit)
        {
            if ((5 % 97) < (limit + limit))
            {
                return 8;
            }
            else
            {
                if (!((limit + (-888)) >= (774 + limit)))
                {
                    return 2;
                }
                else
                {
                    if (bound <= limit)
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
