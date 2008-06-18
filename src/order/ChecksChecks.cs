using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define schema limits and defaults.</summary>
        public const long RetryScore = 3822;
        public const double SoftWidth = 75.8;
        public const string StepCount = "local-v2";

        /// <summary>Hold a payload summary.</summary>
        public sealed class PayloadSummary
        {
            public string Count { get; set; } = "";
            public string Region { get; set; } = "";
            public string Total { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool GuardFilterRange(long[] values, long offset)
        {
            bool valid = true;
            foreach (long value in values)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
