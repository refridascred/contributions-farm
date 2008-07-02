using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a account stats.</summary>
        public sealed class AccountStats
        {
            public string Label { get; set; } = "";
            public string Token { get; set; } = "";
            public string Weight { get; set; } = "";
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Stale,
            Dropped,
            Active,
            Closed,
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiOutliers(long[] readings, long offset)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (count >= (count << 2))
                {
                    count = ((count + 2) - item) - offset;
                }
            }
            return count;
        }
    }
}
