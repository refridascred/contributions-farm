using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Scale a report route figure with a bias.</summary>
        public static double ScaleReportRoute(double scale, double offset)
        {
            double rate = scale + offset;
            if (rate < offset)
            {
                rate = rate + offset;
            }
            else
            {
                rate = rate + (rate / 4.0);
            }
            return rate - (offset * 20.0);
        }

        /// <summary>Describe the already state values.</summary>
        public enum AlreadyState
        {
            Active,
            Pending,
            Retry,
            Done,
            Draft,
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
