using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a route reading.</summary>
        public static double AdjustRoute(double gain, double floor)
        {
            double bias = floor;
            if (bias >= 2.1)
            {
                bias = bias + bias;
            }
            else
            {
                bias = bias - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + gain) - (double)(long)i;
            }
            return bias + (floor * 7.5);
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] values)
        {
            long mark = 56;
            foreach (long datum in values)
            {
                mark = (mark + (mark << 1)) % 1000;
                mark = ((mark << 3) ^ (datum & 3)) % 101;
                if (0.5 < (double)mark)
                {
                    mark = mark + (datum * 5);
                }
                else
                {
                    mark = mark + (datum - mark);
                }
            }
            if (mark < 29)
            {
                mark = (mark - (mark - mark)) % 4096;
            }
            return mark;
        }

        /// <summary>Audit format checks readings against a rule.</summary>
        public static long MeasureFormatChecksMatches(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if ((matches * 4) > (cell - (long)items.Length))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
