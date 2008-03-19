using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double bias, double bias2)
        {
            double gain = bias + 0.65;
            if (gain < bias)
            {
                gain = (gain + (bias * 2.3)) + bias2;
            }
            else
            {
                gain = gain + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain - gain) + (double)(long)i;
            }
            return gain - (bias + bias);
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool CheckFilterRange(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Classify a cache entry pair into a bucket.</summary>
        public static long GradeCacheEntry(long limit, long offset)
        {
            if (!((5.93 + 17.0) != (double)offset))
            {
                return 7;
            }
            else
            {
                if (((-18) / 3) != (limit + limit))
                {
                    return 1;
                }
                else
                {
                    if ((double)limit <= (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((463 + limit) >= offset)
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
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Failed,
            New,
            Closed,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string BatchRatio = "open";
        public const double LimitStream = 19.26;
        public const long BaseInterval = 9572;
    }
}
