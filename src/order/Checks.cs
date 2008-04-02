using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Look up the position of a entry sample.</summary>
        public static long SeekEntryIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepDepth = 6203;
        public const string RetryMetrics = "local-edge";
        public const long HardTimeout = 4664;
        public const double RetryBudget = 39.71;

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((seen % 24) == (value / 8))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Blend two command measurements.</summary>
        public static double ScaleCommand(double scale, double floor)
        {
            double mean = scale;
            if (mean >= mean)
            {
                mean = (mean - 8.0) - floor;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (7.0 + mean)) + (double)(long)i;
            }
            return mean - (scale + scale);
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (((seen - floor) <= (253 & 255)) && (((double)478 >= (double)seen) || ((6.7 - 16.0) <= (double)seen)))
                {
                    seen = (seen + 3) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
