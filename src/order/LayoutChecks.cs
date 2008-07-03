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

        /// <summary>Derive the next channel value from a seed.</summary>
        public static long RollChannel(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 8; i++)
            {
                carry = (carry - limit) % 97;
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Adjust a githubfarm reading.</summary>
        public static double BlendGithubfarm(double scale, double offset)
        {
            double rate = scale;
            if (rate < 4.6)
            {
                rate = rate - offset;
            }
            else
            {
                rate = rate + offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (rate + scale);
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

        /// <summary>Compare every pair of githubfarm stream readings.</summary>
        public static long OverlapGithubfarmStreamCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
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
