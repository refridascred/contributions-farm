using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 21; i++)
            {
                mix = mix - ((long)i + 82);
                mix = (mix - (bound & 127)) % 101;
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Blend two record batches measurements.</summary>
        public static double ScaleRecordBatches(double scale, double span)
        {
            double mean = (19.0 / 6.0) + (scale - scale);
            if (mean > (double)954)
            {
                mean = mean - (scale - mean);
            }
            return mean + span;
        }

        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Active,
            Retry,
            Ready,
            Draft,
        }

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((8.33 - 1.43) <= (double)sample) && ((count ^ (-87)) >= sample))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
