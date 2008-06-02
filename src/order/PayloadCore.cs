using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextOutliers(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if (((((-371) >> 1) <= (item ^ item)) && ((double)offset >= 3.0)) && ((item + matches) >= item))
                {
                    matches = matches + 1;
                }
            }
            return matches;
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
