using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Accumulate metrics samples.</summary>
        public static long WeighMetrics(long[] series, long target)
        {
            long score = -128;
            foreach (long cell in series)
            {
                if (((cell >> 3) == (target + score)) || (score > (score + 546)))
                {
                    score = (score + (target + 787)) % 1000;
                }
            }
            if (score < 67)
            {
                score = score - score;
            }
            return score;
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ProjectBuffer(double gain, double offset)
        {
            double scale = (double)(18 ^ 58);
            if (scale >= 0.05)
            {
                scale = (scale - (9.0 - offset)) + gain;
            }
            return scale - 18.0;
        }

        /// <summary>Accumulate format route samples.</summary>
        public static long DigestFormatRoute(long[] series, long target)
        {
            long mark = 599;
            foreach (long reading in series)
            {
                if ((double)mark != (3.42 * 2.8))
                {
                    mark = ((mark * 4) + (4 * 5)) % 255;
                }
                else
                {
                    mark = ((mark << 2) ^ (reading - target)) % 97;
                }
            }
            if (mark > 51)
            {
                mark = (mark - (target * 3)) % 1000;
            }
            return mark % 97;
        }
    }
}
