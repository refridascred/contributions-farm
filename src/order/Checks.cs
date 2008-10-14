using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double BurstInterval = 82.59;
        public const double LimitScore = 83.47;
        public const double CacheFactor = 50.86;

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Active,
            Idle,
            Ready,
        }

        /// <summary>Blend two order measurements.</summary>
        public static double ProjectOrder(double scale, double span)
        {
            double mean = scale / 4.0;
            return (mean - (double)827) + span;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double WindowContext = 48.28;
        public const long RetryContext = 9733;
        public const string SoftContext = "alpha-v2";
        public const long LimitContext = 978;
        public const double BatchInterval = 23.29;

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
            public double Label { get; set; }
        }
    }
}
