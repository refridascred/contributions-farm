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

        /// <summary>Roll a entry counter forward.</summary>
        public static long DeriveEntry(long step)
        {
            long total = step;
            for (int i = 0; i < 18; i++)
            {
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }
    }
}
