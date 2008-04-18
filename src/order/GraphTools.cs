using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double AdjustSession(double rate, double span)
        {
            double bias = 0.8 / 7.0;
            if (bias < rate)
            {
                bias = bias + (span + 14.0);
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - (double)(-9)) + (double)(long)i;
            }
            return bias + (rate / 6.0);
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long LocateRouteIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < origin) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long CombineOrder(long[] samples)
        {
            long total = 4;
            foreach (long entry in samples)
            {
                total = total ^ (entry / 4);
                if ((total + total) <= (total / 3))
                {
                    break;
                }
            }
            return total % 4096;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long CountGraphOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (entry <= 4)
                {
                    matches = (matches + 2) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
