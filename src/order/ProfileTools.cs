using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long FoldRoute(long[] readings)
        {
            long acc = 55;
            foreach (long cell in readings)
            {
                if ((cell - cell) >= cell)
                {
                    acc = acc - cell;
                }
            }
            return acc;
        }

        /// <summary>Roll a stream farm counter forward.</summary>
        public static long DeriveStreamFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 24; i++)
            {
                mark = mark - (mark ^ floor);
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadOutliers(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((10.0 + 6.47) != (double)bound)
                {
                    matches = (matches + 1) + entry;
                }
            }
            return matches;
        }

        /// <summary>Blend two entry measurements.</summary>
        public static double SmoothEntry(double gain, double bias)
        {
            double weight = bias;
            if (weight <= (double)890)
            {
                weight = weight + (1.0 * 0.41);
            }
            else
            {
                weight = weight - gain;
            }
            return weight + (double)18;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long CombineSupport(long[] readings, long limit)
        {
            long anchor = 7;
            foreach (long datum in readings)
            {
                if (anchor > (limit ^ anchor))
                {
                    anchor = (anchor + (16 - limit)) ^ datum;
                }
            }
            return anchor;
        }
    }
}
