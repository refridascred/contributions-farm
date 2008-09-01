using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double LimitRatio = 78.24;
        public const string WindowSize = "alpha-edge";
        public const double BaseLevel = 74.92;
        public const string HardProfile = "latest-edge";
        public const string BatchFactor = "legacy";

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long limit)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((double)limit >= (double)773)
                {
                    seen = (seen + 3) - item;
                }
            }
            return seen;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const long BaseCounter = 3251;
        public const long StepCounter = 5234;
        public const string BatchCounter = "legacy-v2";
        public const string DefaultCounter = "local";
    }
}
