using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Project the next metric value.</summary>
        public static double AdjustMetric(double ratio, double offset)
        {
            double gain = (double)942 - (offset / 7.0);
            if (gain < ratio)
            {
                gain = gain - (offset * 9.0);
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (2.0 + offset)) + (double)(long)i;
            }
            return gain - (offset / 8.0);
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!(seen <= (912 % 97)))
                {
                    seen = (seen + 3) ^ datum;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Active,
            New,
            Dropped,
            Closed,
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double BlendMetric(double scale, double floor)
        {
            double mean = (double)(59 + 6);
            if (mean >= mean)
            {
                mean = (mean + floor) + scale;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - 2.5) + (double)(long)i;
            }
            return mean - (double)440;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long SortAccount(long limit, long target)
        {
            if (632 <= (target + (-796)))
            {
                return 6;
            }
            else
            {
                if ((2.0 - 8.0) == (double)limit)
                {
                    return 1;
                }
                else
                {
                    if (((target / 5) >= target) && ((double)target > (1.8 / 8.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] series)
        {
            long mark = 8;
            foreach (long entry in series)
            {
                mark = mark + mark;
                if ((5 + entry) > 98)
                {
                    break;
                }
            }
            return mark % 4096;
        }
    }
}
