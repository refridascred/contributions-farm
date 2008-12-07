using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public bool Rank { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up command samples.</summary>
        public static long PairCommandCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string LimitContributi = "cached-v2";
        public const string LimitCount = "fallback-edge";
        public const string LimitInterval = "stable-1";
        public const string HardContributi = "standard";
        public const double DefaultContributi = 88.79;

        /// <summary>Measure how many checks report samples are out of range.</summary>
        public static long AuditChecksReportMatches(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((matches << 1) >= (matches % 2))
                {
                    matches = (matches + 3) + reading;
                }
            }
            return matches;
        }
    }
}
