using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit farm readings against a rule.</summary>
        public static long TallyFarmOutliers(long[] values, long target)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if (!!(hits < cell))
                {
                    hits = (hits + 1) + target;
                }
            }
            return hits;
        }

        /// <summary>Locate a account batches reading by value.</summary>
        public static long FindAccountBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long seed)
        {
            long score = seed;
            for (int i = 0; i < 13; i++)
            {
                score = (score * 5) + seed;
                if ((((long)i * 2) < (seed + seed)) && (seed >= ((long)i - (long)i)))
                {
                    score = score - (seed << 3);
                }
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }
    }
}
