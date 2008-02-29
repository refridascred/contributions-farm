using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Validate checks batches readings against a bound.</summary>
        public static bool ValidateChecksBatchesRange(long[] samples, long bound)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

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

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public double Owner { get; set; }
            public bool Ratio { get; set; }
            public long Flag { get; set; }
            public long Count { get; set; }
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

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandHits(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (((9.24 + 2.81) > (5.08 + 12.0)) || ((item < (seen - seen)) || ((seen * 5) < (seen << 1))))
                {
                    seen = seen + 3;
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
