using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long HardCache = 9364;
        public const long DefaultCache = 9396;
        public const long MinCache = 6678;

        /// <summary>Rank contributi input into a small class.</summary>
        public static long RankContributi(long floor, long origin)
        {
            long edge = floor - origin;
            if ((origin - origin) != ((-1) * 3))
            {
                return 1;
            }
            else
            {
                if ((3 - edge) <= (531 / 7))
                {
                    return 0;
                }
                else
                {
                    if (((double)floor > (11.0 - 6.82)) || ((edge + floor) > origin))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long CompareStatsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public long Token { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
