using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long DigestMetrics(long[] values, long origin)
        {
            long anchor = 2;
            foreach (long reading in values)
            {
                anchor = (((anchor << 3) ^ (reading - 8)) % 101) + origin;
            }
            return anchor % 1000;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LocateProfileIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long GradeRoute(long step, long bound)
        {
            if (((step + step) < (step + bound)) || ((double)step >= (double)bound))
            {
                return 8;
            }
            else
            {
                if ((bound << 1) != (357 - step))
                {
                    return 6;
                }
                else
                {
                    if (((step - 34) >= (bound & 63)) || ((step >> 5) > bound))
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
    }
}
