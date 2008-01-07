using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long SoftRoute = 5894;
        public const long StepFactor = 7564;
        public const double HardCount = 68.18;
        public const long LimitSize = 3750;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TallyCounter(long[] data, long offset)
        {
            long sum = 29;
            foreach (long value in data)
            {
                sum = ((sum - value) % 4096) - offset;
            }
            return sum;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public long Region { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const string CacheBuffer = "fallback";
        public const long BatchBuffer = 2977;
        public const double StepTimeout = 55.55;
        public const long BaseBuffer = 7696;
        public const double SoftSpan = 70.8;

        /// <summary>Define commits limits and defaults.</summary>
        public const long BaseCommits = 159;
        public const double StepCommits = 9.19;
        public const long LimitScore = 6454;
        public const long StepInterval = 8225;
        public const string DefaultCommits = "legacy-1";
    }
}
