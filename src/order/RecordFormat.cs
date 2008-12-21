using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Dropped,
            Draft,
            Idle,
            Locked,
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] items, long target)
        {
            bool flag = true;
            foreach (long reading in items)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountLimits(long[] series, long origin)
        {
            bool ready = true;
            foreach (long value in series)
            {
                if (value != origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string HardInterval = "standard";
        public const long BatchRecord = 1703;
        public const long BaseRecord = 7640;
        public const string MaxCount = "primary-edge";
        public const long CacheInterval = 7385;
    }
}
