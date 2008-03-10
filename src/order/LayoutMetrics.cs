using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if ((13.0 + 6.46) < (double)(long)readings.Length)
                {
                    count = (count + 2) - sample;
                }
            }
            return count;
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool GuardMetricLimits(long[] samples, long bound)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double WindowRatio = 44.26;
        public const long StepSpan = 679;
        public const long DefaultStream = 9635;
    }
}
