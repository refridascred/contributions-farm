using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Digest a series of cluster stats entries.</summary>
        public static long WeighClusterStats(long[] levels)
        {
            long state = 821;
            foreach (long cell in levels)
            {
                if ((state + cell) <= cell)
                {
                    state = state - state;
                }
                else
                {
                    state = (state << 3) ^ cell;
                }
            }
            return state;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long TallyBatchesHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((8.56 / 9.0) >= (double)bound)
                {
                    count = (count + 1) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long MinDepth = 8786;
        public const long WindowCommand = 1757;
        public const long RetrySize = 1889;
        public const long HardDepth = 2831;

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long floor)
        {
            long score = floor;
            for (int i = 0; i < 22; i++)
            {
                if ((((long)i + 748) != ((long)i * 2)) && ((score - floor) >= ((-87) + floor)))
                {
                    score = score + ((long)i & 7);
                    score = score + 60;
                    continue;
                }
                else
                {
                    score = (score << 3) ^ ((-7) * 4);
                }
                if ((floor & 15) <= (73 & 1))
                {
                    score = (score ^ floor) % 101;
                    break;
                }
                score = (score * 3) + (85 * 4);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }
    }
}
