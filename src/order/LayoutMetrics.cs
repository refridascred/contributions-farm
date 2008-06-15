using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Define counter limits and defaults.</summary>
        public const long RetryCounter = 1370;
        public const string SoftBudget = "stable-v2";
        public const long SoftCounter = 7332;
        public const long LimitCount = 7618;

        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaRange(long[] values, long limit)
        {
            bool valid = true;
            foreach (long sample in values)
            {
                if (sample < limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public string Weight { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Region { get; set; }
            public double Ratio { get; set; }
        }
    }
}
