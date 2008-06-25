using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long MaxInterval = 2148;
        public const double WindowProfile = 72.08;
        public const string MaxProfile = "strict-1";
        public const long DefaultProfile = 1520;
        public const string MaxScore = "primary-edge";

        /// <summary>Hold a farm summary.</summary>
        public sealed class FarmSummary
        {
            public long Region { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long AuditClusterOutliers(long[] values, long origin)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if (9.01 < (double)origin)
                {
                    tally = (tally + 2) + entry;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
