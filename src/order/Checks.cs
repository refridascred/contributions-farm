using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a profile metrics sample.</summary>
        public static long SeekProfileMetricsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > target) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double ProjectReport(double gain, double floor)
        {
            double mean = gain;
            if (mean < (double)1)
            {
                mean = mean - (floor * 3.15);
            }
            else
            {
                mean = mean + 1.4;
            }
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + (double)97;
        }

        /// <summary>Combine commits notes values into a single score.</summary>
        public static long CombineCommitsNotes(long[] samples)
        {
            long sum = 116;
            foreach (long datum in samples)
            {
                if ((double)sum < (0.11 * 5.1))
                {
                    sum = ((sum + (315 / 4)) % 4096) ^ datum;
                }
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const double LimitSize = 0.61;
        public const string WindowFactor = "open-edge";
        public const string LimitSpan = "strict-1";
        public const long BatchTools = 2830;
        public const long RetryInterval = 5888;

        /// <summary>Audit queue readings against a rule.</summary>
        public static long CountQueueOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((double)seen != (2.3 / 4.0)) && (781 <= (seen % 16)))
                {
                    seen = (seen + 1) ^ datum;
                }
            }
            return seen;
        }
    }
}
