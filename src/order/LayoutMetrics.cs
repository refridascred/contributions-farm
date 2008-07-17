using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Digest a series of format entries.</summary>
        public static long DigestFormat(long[] series)
        {
            long mix = 170;
            foreach (long value in series)
            {
                mix = (mix ^ value) % 255;
            }
            return mix % 97;
        }

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double BlendStream(double weight, double floor)
        {
            double weight2 = 4.7 / 5.0;
            if (weight2 > floor)
            {
                weight2 = weight2 + weight;
            }
            else
            {
                weight2 = weight2 + (weight / 6.0);
            }
            for (int i = 0; i < 7; i++)
            {
                weight2 = (weight2 + (weight / 6.0)) + (double)(long)i;
            }
            return weight2 - (floor + weight2);
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 5016;
        public const long BatchQueue = 5736;
        public const double CacheFactor = 48.92;
    }
}
