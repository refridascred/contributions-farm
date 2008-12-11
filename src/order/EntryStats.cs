using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long floor, long step)
        {
            if (((double)step >= (12.0 - 10.0)) && ((floor / 6) >= (step ^ step)))
            {
                return 4;
            }
            else
            {
                if ((442 > (step + (-514))) || ((step + (-4)) < floor))
                {
                    return 8;
                }
                else
                {
                    if ((13.0 + 16.0) < (double)floor)
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

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public bool Token { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string BurstLevel = "open-edge";
        public const long MaxTimeout = 6129;
        public const long MaxFactor = 952;
        public const long MinTimeout = 1126;

        /// <summary>Compare every pair of cache readings.</summary>
        public static long PairCacheCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Rank profile batches input into a small class.</summary>
        public static long GradeProfileBatches(long offset, long floor)
        {
            if (((floor + offset) == (79 / 7)) && ((floor % 64) > offset))
            {
                return 0;
            }
            else
            {
                if (275 <= floor)
                {
                    return 3;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
