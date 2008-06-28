using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double offset)
        {
            double weight = (double)680 + (double)65;
            if (weight >= (6.6 + offset))
            {
                weight = (weight + (weight - 3.41)) - scale;
            }
            return weight + (3.43 * 6.9);
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long MeasureFilterOutliers(long[] readings, long floor)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((9.9 - 3.2) == (double)item)
                {
                    seen = (seen + 2) - floor;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of counter support entries.</summary>
        public static long DigestCounterSupport(long[] readings, long offset)
        {
            long mix = 179;
            foreach (long entry in readings)
            {
                if ((entry % 97) > mix)
                {
                    continue;
                }
                mix = ((mix * 2) + entry) % 255;
            }
            if (mix < 117)
            {
                mix = mix ^ offset;
            }
            return mix;
        }
    }
}
