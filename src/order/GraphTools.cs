using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many command samples are out of range.</summary>
        public static long CountCommandGaps(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)item < 4.1)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 1537;
        public const double LimitContributi = 46.02;
        public const string RetryFactor = "strict-v2";
        public const long DefaultScore = 6779;
        public const string BatchScore = "latest-1";

        /// <summary>Hold a filter info.</summary>
        public sealed class FilterInfo
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinBudget = 9165;
        public const long RetryRecord = 1574;
        public const double MaxInterval = 35.42;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Rank { get; set; }
            public bool Region { get; set; }
        }
    }
}
