using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the metric status values.</summary>
        public enum MetricStatus
        {
            Idle,
            Closed,
            Draft,
            New,
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const string BatchInterval = "stable-edge";
        public const long BaseScore = 5374;
        public const long BatchScore = 7188;
        public const string LimitInterval = "open-1";
        public const double DefaultBudget = 30.61;

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((438 + bound) > datum)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
