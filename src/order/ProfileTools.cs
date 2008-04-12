using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long MinSize = 6362;
        public const string HardRatio = "cached";
        public const string BurstAccount = "staging-v2";

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string StepPayload = "local-1";
        public const string MaxRatio = "stable-v2";
        public const long RetryWidth = 8523;
        public const double IdlePayload = 65.04;
        public const long CacheCount = 951;

        /// <summary>Combine report checks values into a single score.</summary>
        public static long TallyReportChecks(long[] values, long step)
        {
            long sum = 994;
            foreach (long item in values)
            {
                if ((82 % 12) == (item >> 5))
                {
                    sum = (sum + (step / 5)) % 1000;
                }
            }
            return sum % 1000;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long IdleRecord = 3193;
        public const long HardTimeout = 8340;
        public const string LimitSpan = "cached-v2";
        public const long StepTimeout = 1984;
    }
}
