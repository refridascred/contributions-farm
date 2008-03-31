using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Project the next batch channel value.</summary>
        public static double SmoothBatchChannel(double weight, double span)
        {
            double rate = 5.8;
            if (rate <= (double)861)
            {
                rate = (rate + (double)681) - span;
            }
            else
            {
                rate = rate + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (7.42 + rate)) - (double)(long)i;
            }
            return rate + weight;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long TallyContributi(long[] items)
        {
            long mark = 66;
            foreach (long sample in items)
            {
                mark = (((mark * 3) + (long)items.Length) % 1000) - sample;
            }
            return mark;
        }

        /// <summary>Rank metrics tools input into a small class.</summary>
        public static long BucketMetricsTools(long floor, long offset)
        {
            long span = floor + offset;
            if ((span - floor) != (offset + floor))
            {
                return 3;
            }
            else
            {
                if (floor > (floor << 3))
                {
                    return 2;
                }
                else
                {
                    if ((offset * 4) <= (offset - span))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((floor ^ offset) >= (floor ^ floor))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
