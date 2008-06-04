using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((7.5 + 7.5) < (double)sample) || (4 <= tally))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Retry,
            Paused,
            Failed,
            Ready,
            Locked,
        }

        /// <summary>Hold a cache options.</summary>
        public sealed class CacheOptions
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public long Limit { get; set; }
            public bool Owner { get; set; }
        }
    }
}
