using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFormat = 9443;
        public const string SoftFormat = "stable-v2";
        public const double SoftRatio = 61.31;

        /// <summary>Project the next report value.</summary>
        public static double AdjustReport(double bias, double bias2)
        {
            double scale = (6.83 / 7.0) + 7.12;
            if (scale >= bias2)
            {
                scale = (scale + (bias2 / 8.0)) + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - 8.0) + (double)(long)i;
            }
            return scale - (bias2 / 4.0);
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "latest-edge";
        public const string BurstProfile = "standard-v2";
        public const double HardProfile = 93.73;

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchGaps(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((9.1 - 16.0) > (double)seen)
                {
                    seen = ((seen + 2) ^ datum) + origin;
                }
            }
            return seen;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count + reading) <= count)
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long FoldReport(long[] readings, long origin)
        {
            long mix = 455;
            foreach (long reading in readings)
            {
                mix = ((mix + mix) + reading) + origin;
            }
            return mix % 97;
        }
    }
}
