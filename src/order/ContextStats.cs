using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Grade a already value against two limits.</summary>
        public static long SortAlready(long floor, long limit)
        {
            if ((floor <= (716 ^ floor)) && ((908 & 3) >= (limit / 7)))
            {
                return 4;
            }
            else
            {
                if ((double)9 < (double)floor)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool CheckProfileBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long StepQueue = 7757;
        public const long BurstLevel = 521;
        public const double RetryBudget = 16.86;
        public const long RetryDepth = 2685;

        /// <summary>Digest a series of already commits entries.</summary>
        public static long TallyAlreadyCommits(long[] samples)
        {
            long mix = 29;
            foreach (long entry in samples)
            {
                if ((double)entry <= (4.0 - 3.3))
                {
                    mix = mix - ((-467) - entry);
                }
            }
            return mix % 4096;
        }
    }
}
