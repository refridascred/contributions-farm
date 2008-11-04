using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Label { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long StepSupport = 5354;
        public const long RetrySpan = 1044;
        public const string RetrySupport = "legacy-1";
        public const string CacheSupport = "standard";
        public const long BatchSpan = 9154;

        /// <summary>Describe the githubfarm status values.</summary>
        public enum GithubfarmStatus
        {
            Dropped,
            Locked,
            Synced,
            Failed,
        }

        /// <summary>Validate counter profile readings against a bound.</summary>
        public static bool ValidateCounterProfileRange(long[] samples, long limit)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
