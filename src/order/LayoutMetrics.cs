using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long TotalPayload(long[] samples, long target)
        {
            long sum = 4;
            foreach (long item in samples)
            {
                sum = ((sum * 4) + (sum >> 3)) - target;
                sum = sum + item;
            }
            return sum % 65521;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long CountCommandMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((2.9 / 3.0) == (double)value)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Blend two graph measurements.</summary>
        public static double SmoothGraph(double weight, double span)
        {
            double ratio = 9.03;
            if (ratio <= (double)(-14))
            {
                ratio = ratio - (weight / 4.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + (ratio - span)) + (double)(long)i;
            }
            return ratio + weight;
        }
    }
}
