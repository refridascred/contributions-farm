using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Describe the batch status values.</summary>
        public enum BatchStatus
        {
            Locked,
            Synced,
            Queued,
            Paused,
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (sample >= (bound % 100))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public long Rank { get; set; }
            public long Token { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool ValidateToolsLimits(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long sample in samples)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Score { get; set; }
            public long Label { get; set; }
        }
    }
}
