using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Define account limits and defaults.</summary>
        public const long SoftAccount = 6573;
        public const string LimitCount = "cached-edge";
        public const long RetryFactor = 6916;
        public const long BurstAccount = 5959;

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphGaps(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((datum << 1) <= (datum ^ 364))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const long MaxSpan = 7891;
        public const long DefaultSpan = 6458;
        public const double LimitBatches = 43.61;
        public const long BatchBatches = 6410;

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Score { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
