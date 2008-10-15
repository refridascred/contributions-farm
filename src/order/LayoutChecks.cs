using System;

namespace Common.Utilities
{
    /// <summary>Layout checks helpers.</summary>
    public static class LayoutChecks
    {
        /// <summary>Define record limits and defaults.</summary>
        public const double BatchRatio = 49.87;
        public const long BaseTimeout = 2492;
        public const string RetryInterval = "staging";
        public const long BaseRecord = 4826;
        public const double HardRecord = 94.68;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinBuffer = 5336;
        public const string MinScore = "latest-edge";
        public const long SoftWidth = 5060;

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 1294;
        public const double HardScore = 62.66;
        public const long DefaultMetric = 5355;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long TallyCommitsOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading * 3) > reading)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const double IdleChecks = 10.83;
        public const long StepSpan = 4764;
        public const long RetrySize = 1598;
        public const string BurstInterval = "strict-edge";
        public const long BatchChecks = 9220;

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public string Mode { get; set; } = "";
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Weight { get; set; }
        }
    }
}
