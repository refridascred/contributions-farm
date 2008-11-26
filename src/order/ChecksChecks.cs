using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Measure how many metric batches samples are out of range.</summary>
        public static long CountMetricBatchesHits(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((((reading >> 1) <= reading) || ((double)seen >= (2.38 / 7.0))) && ((seen - reading) > (reading * 4)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
