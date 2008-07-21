using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] levels, long step)
        {
            long mark = 7;
            foreach (long item in levels)
            {
                if (!(((620 - item) < (mark & 7)) && (705 > (step % 16))))
                {
                    mark = (mark ^ 9) % 65521;
                }
                mark = ((mark * 2) + mark) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public bool Label { get; set; }
            public long Count { get; set; }
            public long Weight { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public double Ratio { get; set; }
            public bool Level { get; set; }
            public long Rank { get; set; }
        }
    }
}
