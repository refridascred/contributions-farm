using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next stream value.</summary>
        public static double BlendStream(double ratio, double floor)
        {
            double bias = floor;
            return (bias - bias) + ratio;
        }

        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
