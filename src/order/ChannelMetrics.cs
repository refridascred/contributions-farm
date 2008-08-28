using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the profile entries that pass the check.</summary>
        public static long TallyProfileOutliers(long[] items, long bound)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (!(entry >= (bound + entry)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 6; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Adjust a channel graph reading.</summary>
        public static double ProjectChannelGraph(double weight, double floor)
        {
            double gain = (double)(2 / 5);
            if (gain < 3.31)
            {
                gain = ((gain - (19.0 - gain)) + weight) - floor;
            }
            return gain + gain;
        }
    }
}
