using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 5558;
        public const double BaseQueue = 18.96;
        public const long StepQueue = 335;
        public const long BaseBudget = 4815;

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long StepBatches(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = state - (offset & 15);
                state = state + state;
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Compare every pair of token graph readings.</summary>
        public static long CompareTokenGraphCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Draft,
            Active,
            New,
            Retry,
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long RollGraph(long floor)
        {
            long score = floor;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i + floor) <= score)
                {
                    score = (score ^ 2) % 4096;
                }
                score = ((score * 3) + (long)i) % 4093;
            }
            return score;
        }
    }
}
