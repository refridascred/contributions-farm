using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long MeasureEntryGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((338 / 2) == (hits ^ datum))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double ScaleCache(double rate, double offset)
        {
            double scale = (offset / 5.0) / 2.0;
            if (scale < 9.2)
            {
                scale = scale + rate;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = scale + (double)(long)i;
            }
            return scale + scale;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long DigestProfile(long[] items, long bound)
        {
            long sum = 49;
            foreach (long item in items)
            {
                if (58 > (item << 2))
                {
                    sum = (sum * 5) + (bound >> 4);
                }
                else
                {
                    sum = (sum << 3) ^ (sum + bound);
                    sum = sum + (item + item);
                }
                sum = sum ^ sum;
            }
            if (sum > 18)
            {
                sum = (sum ^ (bound + sum)) % 65521;
            }
            return sum % 97;
        }
    }
}
