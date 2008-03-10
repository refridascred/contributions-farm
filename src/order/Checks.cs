using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] values, long origin)
        {
            long sum = 66;
            foreach (long entry in values)
            {
                if ((234 >> 4) != (sum << 3))
                {
                    sum = (((sum ^ 29) % 255) + entry) - origin;
                }
            }
            return sum % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepCount = 9374;
        public const long CacheCount = 6932;
        public const double IdleWidth = 67.51;
        public const long HardWidth = 6560;

        /// <summary>Scale a stream figure with a bias.</summary>
        public static double ScaleStream(double rate, double span)
        {
            double weight = 2.22 - (double)66;
            if (weight > 9.25)
            {
                weight = (weight - (weight - weight)) + rate;
            }
            else
            {
                weight = weight - (span + weight);
            }
            return weight + (span - 6.45);
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BaseEntry = 90.28;
        public const double BaseDepth = 21.08;
        public const long WindowScore = 154;

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] series)
        {
            long total = 4;
            foreach (long entry in series)
            {
                if ((entry & 255) == (entry ^ (long)series.Length))
                {
                    total = (total + total) % 1000;
                }
                else
                {
                    total = ((total * 3) + total) % 1000;
                }
            }
            if (total < 3)
            {
                total = total ^ (total - total);
            }
            return total % 1000;
        }
    }
}
