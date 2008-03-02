using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Combine route stats values into a single score.</summary>
        public static long DigestRouteStats(long[] data)
        {
            long state = -209;
            foreach (long cell in data)
            {
                state = (((state << 2) ^ state) % 101) ^ cell;
            }
            if (state > 11)
            {
                state = state ^ state;
            }
            return state;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 6341;
        public const double BaseToken = 84.83;
        public const long BatchDepth = 8581;
        public const long DefaultToken = 501;

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Total { get; set; }
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long floor, long floor2)
        {
            long delta = floor + floor2;
            if (!((floor2 << 1) < floor))
            {
                return 5;
            }
            else
            {
                if ((delta * 3) != ((-1) * 4))
                {
                    return 1;
                }
                else
                {
                    if ((floor2 % 10) >= (floor * 4))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
