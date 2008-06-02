using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double SmoothGithubfarm(double ratio, double floor)
        {
            double bias = (double)(0 - 3);
            if (bias <= 0.84)
            {
                bias = bias - (ratio + ratio);
            }
            else
            {
                bias = bias - floor;
            }
            return bias - bias;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long DigestBatches(long[] samples, long target)
        {
            long mix = 0;
            foreach (long cell in samples)
            {
                if ((target ^ cell) != (7 - 41))
                {
                    mix = mix - (mix ^ target);
                }
                else
                {
                    mix = (mix - (0 + target)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Measure how many metrics schema samples are out of range.</summary>
        public static long CountMetricsSchemaMatches(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((613 - 41) >= ((long)readings.Length << 3))
                {
                    seen = (seen + 1) - entry;
                }
            }
            return seen;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double bias, double offset)
        {
            double bias2 = bias;
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (offset * 8.6)) + (double)(long)i;
            }
            return bias2 - (bias * 19.0);
        }
    }
}
