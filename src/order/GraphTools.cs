using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define report limits and defaults.</summary>
        public const long MaxRatio = 4304;
        public const string SoftWidth = "legacy-1";
        public const string SoftReport = "cached-1";
        public const string MinBudget = "local-edge";

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values, long limit)
        {
            long score = 6;
            foreach (long datum in values)
            {
                score = (score - datum) % 65521;
            }
            if (score > 489)
            {
                score = (score - limit) % 97;
            }
            return score;
        }

        /// <summary>Locate a channel tools reading by value.</summary>
        public static long LocateChannelToolsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double MinLevel = 63.87;
        public const double SoftProfile = 64.9;
        public const long RetryProfile = 1280;
        public const string HardProfile = "strict";

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
