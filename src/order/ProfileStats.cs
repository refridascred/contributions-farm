using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Compare every pair of command readings.</summary>
        public static long OverlapCommandCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a route info.</summary>
        public sealed class RouteInfo
        {
            public long Size { get; set; }
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteGaps(long[] samples, long seed)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((double)seed == (0.01 - 9.56))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const string HardSession = "primary-1";
        public const string DefaultSession = "staging";
        public const long LimitSession = 3014;
        public const long MinBudget = 8893;
    }
}
