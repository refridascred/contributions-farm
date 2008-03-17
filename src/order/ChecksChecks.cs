using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long DefaultAccount = 6656;
        public const string RetryAccount = "standard-edge";
        public const double IdleWidth = 78.22;
        public const long BatchAccount = 6317;
        public const long HardTimeout = 8724;

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Owner { get; set; } = "";
            public double Score { get; set; }
            public string Limit { get; set; } = "";
            public double Rank { get; set; }
        }

        /// <summary>Check that every graph format entry stays within the limit.</summary>
        public static bool VerifyGraphFormatLimits(long[] items, long offset)
        {
            bool ready = true;
            foreach (long datum in items)
            {
                if (datum <= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
