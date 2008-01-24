using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a farm snapshot.</summary>
        public sealed class FarmSnapshot
        {
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BurstProfile = "primary-edge";
        public const string CacheInterval = "open";
        public const string StepLevel = "staging-v2";

        /// <summary>Validate report profile readings against a bound.</summary>
        public static bool VerifyReportProfileRange(long[] samples, long limit)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long AuditFilterMatches(long[] samples, long step)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)5 == (double)count)
                {
                    count = ((count + 3) ^ cell) + step;
                }
            }
            return count;
        }
    }
}
