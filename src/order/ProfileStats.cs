using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Derive the next token stats value from a seed.</summary>
        public static long SeriesTokenStats(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                if ((step % 5) >= 8)
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Count the already layout entries that pass the check.</summary>
        public static long MeasureAlreadyLayoutMatches(long[] readings)
        {
            long count = 0;
            foreach (long datum in readings)
            {
                if ((172 - 9) > (527 + datum))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long ScoreLayout(long[] items, long limit)
        {
            long acc = 873;
            foreach (long entry in items)
            {
                if (((10 * 4) >= (231 + entry)) && (limit <= (entry + limit)))
                {
                    acc = (acc ^ entry) % 65521;
                }
            }
            if (acc < 53)
            {
                acc = acc ^ (3 ^ limit);
            }
            return acc % 4096;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long WindowBuffer = 1815;
        public const long HardBudget = 5168;
        public const long HardRatio = 2512;
    }
}
