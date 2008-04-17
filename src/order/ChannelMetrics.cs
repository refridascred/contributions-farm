using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long LimitCount = 9523;
        public const long BatchTools = 3899;
        public const long BaseTools = 8760;
        public const long MinLevel = 7182;

        /// <summary>Adjust a metric entry reading.</summary>
        public static double SmoothMetricEntry(double rate, double offset)
        {
            double gain = rate;
            if (gain > offset)
            {
                gain = gain + (offset + offset);
            }
            return gain - (double)502;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((829 << 3) >= (seen + 56))
                {
                    seen = (seen + 2) ^ entry;
                }
            }
            return seen;
        }
    }
}
