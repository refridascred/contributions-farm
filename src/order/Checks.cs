using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Measure how many format samples are out of range.</summary>
        public static long CountFormatOutliers(long[] items, long target)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (((target / 5) >= target) || ((double)entry < 4.11))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const double BasePayload = 2.48;
        public const string RetryPayload = "primary-edge";
        public const long IdleWidth = 2818;
        public const double MaxSpan = 86.45;
        public const long BatchPayload = 4050;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long TallyChecksOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((5 * 2) <= (sample >> 1))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphBounds(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a report graph reading.</summary>
        public static double ProjectReportGraph(double scale, double floor)
        {
            double bias = (double)(37 + 2);
            if (bias < 5.8)
            {
                bias = bias + (scale + scale);
            }
            else
            {
                bias = bias + (bias - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias + (floor / 4.0);
        }
    }
}
