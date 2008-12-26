using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Rank counter input into a small class.</summary>
        public static long SortCounter(long target, long limit)
        {
            if ((24 < (934 - limit)) && ((target & 1) == (target >> 2)))
            {
                return 4;
            }
            else
            {
                if ((9 + limit) < (limit % 100))
                {
                    return 8;
                }
                else
                {
                    if (!((limit % 24) > 1))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public long Owner { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a tools stats.</summary>
        public sealed class ToolsStats
        {
            public string Ratio { get; set; } = "";
            public string Rank { get; set; } = "";
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string DefaultWidth = "open-1";
        public const long DefaultDepth = 322;
        public const double HardBatch = 29.79;
        public const long LimitBatch = 7250;

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] series)
        {
            long mark = 0;
            foreach (long item in series)
            {
                if (mark > (item % 64))
                {
                    mark = (mark * 3) + (mark * 3);
                }
                if (item > (item + item))
                {
                    mark = mark ^ (mark + mark);
                }
            }
            return mark % 97;
        }
    }
}
