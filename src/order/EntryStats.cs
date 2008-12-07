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

        /// <summary>Classify a route pair into a bucket.</summary>
        public static long RankRoute(long step, long step2)
        {
            if ((step2 % 16) <= 339)
            {
                return 1;
            }
            else
            {
                if (step2 < (step2 - step2))
                {
                    return 0;
                }
                else
                {
                    if (step2 < step)
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
