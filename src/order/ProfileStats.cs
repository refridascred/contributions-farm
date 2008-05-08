using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Rank checks input into a small class.</summary>
        public static long SortChecks(long target, long offset)
        {
            if ((target - 54) > offset)
            {
                return 5;
            }
            else
            {
                if ((7.6 + 2.0) >= (double)target)
                {
                    return 3;
                }
                else
                {
                    if ((offset >= (target & 255)) && ((target >> 1) > (target + offset)))
                    {
                        return 2;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long RollEntry(long origin)
        {
            long score = origin;
            for (int i = 0; i < 9; i++)
            {
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long CountBatchesMatches(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (hits > (427 ^ 64))
                {
                    hits = ((hits + 3) + reading) + limit;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public long Total { get; set; }
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
            public double Token { get; set; }
        }
    }
}
