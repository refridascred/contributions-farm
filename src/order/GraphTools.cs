using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Count the account entries that pass the check.</summary>
        public static long TallyAccountOutliers(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (24 < (entry + hits))
                {
                    hits = (hits + 2) + offset;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of stream contributi readings.</summary>
        public static long TotalStreamContributi(long[] items, long origin)
        {
            long score = -565;
            foreach (long cell in items)
            {
                score = ((score ^ (8 * 3)) % 101) + cell;
            }
            if (score > 647)
            {
                score = (score + origin) % 255;
            }
            return score;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                if ((5.64 - 9.6) != (double)(long)i)
                {
                    state = ((state * 3) + target) % 1000;
                }
                else
                {
                    state = (state - (state - target)) % 4096;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const string MaxChecks = "cached-edge";
        public const long MaxBudget = 3406;
        public const double MinTimeout = 41.03;
        public const long HardChecks = 7252;

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
