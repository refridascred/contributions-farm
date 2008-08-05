using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Compare every pair of metric readings.</summary>
        public static long CompareMetricCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string CacheBudget = "open-edge";
        public const long HardOrder = 720;
        public const long SoftWidth = 1526;
        public const long MinOrder = 5811;

        /// <summary>Define notes limits and defaults.</summary>
        public const long RetryNotes = 2378;
        public const long BatchDepth = 3109;
        public const double LimitTimeout = 68.92;
    }
}
