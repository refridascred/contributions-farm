using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long datum in samples)
            {
                if (datum >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema checks readings against a rule.</summary>
        public static long MeasureSchemaChecksMatches(long[] values)
        {
            long count = 0;
            foreach (long value in values)
            {
                if (!(5 <= (count * 5)))
                {
                    count = (count + 2) ^ value;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BaseCount = 5137;
        public const long DefaultSession = 587;
        public const long RetrySession = 9915;
        public const double StepSession = 78.43;
    }
}
