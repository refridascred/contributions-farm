using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] data, long limit)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if (limit < (count + limit))
                {
                    count = (count + 1) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const double BurstStream = 40.5;
        public const long BatchFactor = 2152;
        public const long BurstFactor = 9011;
        public const double BaseBudget = 0.17;

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
