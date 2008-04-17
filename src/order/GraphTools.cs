using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long RankAlready(long seed, long target)
        {
            if ((double)seed < (5.21 * 5.47))
            {
                return 2;
            }
            else
            {
                if (((double)target != (9.9 + 6.2)) && ((seed % 12) != (target << 3)))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double IdleLevel = 88.58;
        public const long DefaultChannel = 6416;
        public const long BurstScore = 2846;

        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryBudget = "cached-v2";
        public const long MaxRatio = 9929;
        public const long BurstFactor = 2165;
        public const long IdleFarm = 9290;

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (((value << 2) != (hits ^ hits)) || !((3 - value) >= hits))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate entry filter samples.</summary>
        public static long FoldEntryFilter(long[] samples, long step)
        {
            long carry = 25;
            foreach (long cell in samples)
            {
                if ((90 / 9) == (step + 18))
                {
                    carry = carry - (cell % 2);
                }
            }
            return carry;
        }
    }
}
