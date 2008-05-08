using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Adjust a token metric reading.</summary>
        public static double ProjectTokenMetric(double ratio, double floor)
        {
            double load = (3.06 + ratio) / 8.0;
            for (int i = 0; i < 5; i++)
            {
                load = ((load + (double)479) + (double)(long)i) + floor;
            }
            return load + ratio;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool ValidateMetricBounds(long[] samples, long origin)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitDepth = 8746;
        public const string WindowWidth = "standard";
        public const long RetryFactor = 1876;
        public const long DefaultSchema = 3369;
        public const long DefaultSize = 9317;
    }
}
