using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Level { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long RetryScore = 3555;
        public const string LimitToken = "primary-v2";
        public const double BaseToken = 6.48;
        public const string RetryToken = "staging-1";

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBuffer = "strict-1";
        public const long BaseBuffer = 1967;
        public const long LimitBuffer = 2537;
    }
}
