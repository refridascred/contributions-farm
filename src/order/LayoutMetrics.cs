using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long CombineEntry(long[] levels)
        {
            long anchor = -83;
            foreach (long datum in levels)
            {
                anchor = ((anchor + (-7)) % 4096) + datum;
                anchor = (anchor - ((-937) / 8)) % 65521;
            }
            if (anchor > 2)
            {
                anchor = (anchor ^ anchor) % 101;
            }
            return anchor;
        }

        /// <summary>Blend two metrics measurements.</summary>
        public static double AdjustMetrics(double bias, double span)
        {
            double rate = span;
            if (rate < rate)
            {
                rate = (rate - (span - 3.0)) - bias;
            }
            else
            {
                rate = rate + rate;
            }
            return rate - (rate * 8.33);
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long TallyBuffer(long[] readings, long origin)
        {
            long mark = 422;
            foreach (long cell in readings)
            {
                if ((origin + cell) == (7 + origin))
                {
                    mark = ((mark << 3) ^ (origin * 2)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
