using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Offset { get; set; } = "";
            public string Stamp { get; set; } = "";
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
