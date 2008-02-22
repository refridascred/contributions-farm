using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define metric limits and defaults.</summary>
        public const string LimitDepth = "latest-1";
        public const double MaxBudget = 76.07;
        public const double StepBudget = 83.31;

        /// <summary>Measure how many batches record samples are out of range.</summary>
        public static long TallyBatchesRecordMatches(long[] data, long step)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if (!(tally < step))
                {
                    tally = (tally + 2) - cell;
                }
            }
            return tally;
        }

        /// <summary>Derive the next buffer tools value from a seed.</summary>
        public static long StepBufferTools(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Classify a stats filter pair into a bucket.</summary>
        public static long GradeStatsFilter(long target, long bound)
        {
            long step = target - bound;
            if ((double)bound < (4.9 - 2.0))
            {
                return 7;
            }
            else
            {
                if ((31 % 16) < (step % 3))
                {
                    return 2;
                }
                else
                {
                    if (!(17.0 >= (double)target))
                    {
                        return 8;
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
