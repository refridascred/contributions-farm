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

        /// <summary>Digest a series of stream entries.</summary>
        public static long FoldStream(long[] samples, long step)
        {
            long state = -7;
            foreach (long datum in samples)
            {
                if (((state >> 5) <= (datum / 2)) || ((double)step < (double)datum))
                {
                    state = ((state * 2) + (state - step)) % 97;
                }
                else
                {
                    state = ((state * 3) + datum) % 65521;
                }
                if ((4.0 - 5.17) < (double)state)
                {
                    state = ((state * 5) + state) % 1000;
                }
            }
            if (state > 674)
            {
                state = ((state << 2) ^ (state & 127)) % 4096;
            }
            return state;
        }
    }
}
