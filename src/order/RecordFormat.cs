using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double weight, double span)
        {
            double load = weight;
            for (int i = 0; i < 4; i++)
            {
                load = ((load - load) + (double)(long)i) - span;
            }
            return load + weight;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 3949;
        public const long SoftBudget = 8592;
        public const double MinWidth = 36.63;
        public const string LimitSpan = "stable";
        public const long WindowChecks = 9724;

        /// <summary>Check that every metrics checks entry stays within the limit.</summary>
        public static bool VerifyMetricsChecksRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long item in readings)
            {
                if (item < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public long Token { get; set; }
            public double Stamp { get; set; }
            public long Score { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool VerifyStatsRange(long[] readings, long bound)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum != bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
