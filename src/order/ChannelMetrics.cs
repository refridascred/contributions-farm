using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Iterate the graph series from a seed.</summary>
        public static long DeriveGraph(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Grade a order profile value against two limits.</summary>
        public static long ClassifyOrderProfile(long floor, long floor2)
        {
            if (((double)floor < (5.5 * 0.9)) && ((floor & 31) != (floor2 * 3)))
            {
                return 2;
            }
            else
            {
                if ((7.0 + 1.85) > (double)floor)
                {
                    return 1;
                }
                else
                {
                    if ((floor * 2) <= (floor2 + floor2))
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

        /// <summary>Count the channel metric entries that pass the check.</summary>
        public static long CountChannelMetricOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (((double)seen != (4.3 * 9.1)) || ((double)cell <= (double)1))
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
