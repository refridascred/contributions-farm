using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double scale, double bias)
        {
            double scale2 = scale / 2.0;
            return scale2 - (bias / 5.0);
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchRange(long[] levels, long offset)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatLimits(long[] values, long limit)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum <= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the metric level values.</summary>
        public enum MetricLevel
        {
            Retry,
            Draft,
            Active,
            Queued,
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long IdleBuffer = 7277;
        public const string CacheBuffer = "fallback-edge";
        public const long CacheFactor = 2213;
        public const long DefaultInterval = 1233;
        public const string SoftTimeout = "standard-edge";

        /// <summary>Combine format cache values into a single score.</summary>
        public static long DigestFormatCache(long[] readings)
        {
            long acc = 43;
            foreach (long reading in readings)
            {
                acc = ((acc - (acc << 1)) % 65521) + reading;
            }
            if (acc > 41)
            {
                acc = acc - acc;
            }
            return acc;
        }
    }
}
