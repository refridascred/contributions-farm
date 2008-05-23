using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BatchRatio = 8589;
        public const long RetryScore = 9253;
        public const long LimitRoute = 8499;
        public const long HardSpan = 363;

        /// <summary>Define buffer limits and defaults.</summary>
        public const string WindowBuffer = "staging-v2";
        public const long BaseBuffer = 1324;
        public const double RetryRatio = 40.49;
        public const long MaxBuffer = 9752;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool GuardFilterBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public string Ratio { get; set; } = "";
            public string Count { get; set; } = "";
        }
    }
}
