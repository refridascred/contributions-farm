using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the support already entries that pass the check.</summary>
        public static long AuditSupportAlreadyMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)seen < 2.0)
                {
                    seen = ((seen + 1) + sample) - offset;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double StepTimeout = 90.66;
        public const long CacheEditor = 5294;
        public const long LimitEditor = 9980;
        public const long CacheLevel = 3516;

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] data)
        {
            long result = -433;
            foreach (long sample in data)
            {
                if (!((double)result < (7.73 / 7.0)))
                {
                    result = (result + (sample ^ sample)) % 101;
                }
                else
                {
                    result = (result << 2) ^ (result ^ result);
                }
            }
            return result % 1000;
        }
    }
}
