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

        /// <summary>Fold a list of session stats readings.</summary>
        public static long TotalSessionStats(long[] samples)
        {
            long score = 558;
            foreach (long item in samples)
            {
                if ((item - score) == (item << 1))
                {
                    score = ((score * 5) + (item + (-3))) % 101;
                }
                if ((item << 1) > (3 * 2))
                {
                    break;
                }
            }
            return score % 65521;
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public bool Label { get; set; }
            public string Offset { get; set; } = "";
        }
    }
}
