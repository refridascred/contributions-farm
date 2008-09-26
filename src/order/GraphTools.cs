using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long CountContextGaps(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((matches + cell) >= (cell / 7))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool CheckTokenRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long entry in series)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
