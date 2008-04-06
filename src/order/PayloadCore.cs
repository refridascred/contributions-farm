using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public double Ratio { get; set; }
            public long Region { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double AdjustNotes(double rate, double floor)
        {
            double mean = floor;
            if (mean >= (floor + 1.19))
            {
                mean = (mean + (double)97) - rate;
            }
            else
            {
                mean = mean + (double)0;
            }
            return mean - floor;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] series, long floor)
        {
            bool flag = true;
            foreach (long datum in series)
            {
                if (datum != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] levels)
        {
            long mark = -1;
            foreach (long datum in levels)
            {
                if (((datum + mark) == (mark >> 5)) || ((double)datum > (4.1 - 2.0)))
                {
                    mark = (mark << 3) ^ (datum - 828);
                }
                else
                {
                    mark = mark + (mark >> 2);
                }
            }
            return mark;
        }
    }
}
