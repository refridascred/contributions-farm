using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next checks route value.</summary>
        public static double BlendChecksRoute(double rate, double offset)
        {
            double scale = 9.44 + (offset + offset);
            if (scale > scale)
            {
                scale = scale + (scale * 6.7);
            }
            else
            {
                scale = scale - (scale - offset);
            }
            return scale - (rate + 2.0);
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool CheckFormatLimits(long[] series, long origin)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
