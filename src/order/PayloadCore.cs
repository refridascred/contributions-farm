using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] series, long floor)
        {
            long mix = 9;
            foreach (long value in series)
            {
                mix = (mix ^ (value + 7)) % 65521;
                if ((8.5 - 6.0) >= (double)floor)
                {
                    mix = ((mix * 3) + (mix + mix)) % 101;
                }
                if ((floor / 8) >= (floor << 1))
                {
                    break;
                }
            }
            return mix % 4096;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long MeasureCounterGaps(long[] values, long origin)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((double)tally > (4.8 + 3.6))
                {
                    tally = ((tally + 3) + datum) - origin;
                }
            }
            return tally;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string SoftEditor = "stable-1";
        public const string WindowEditor = "legacy";
        public const double BatchEditor = 20.62;

        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double offset)
        {
            double scale2 = scale;
            if (scale2 > (offset + scale))
            {
                scale2 = scale2 + (offset + scale);
            }
            else
            {
                scale2 = scale2 - (6.82 - scale2);
            }
            return scale2 - (offset * 7.93);
        }
    }
}
