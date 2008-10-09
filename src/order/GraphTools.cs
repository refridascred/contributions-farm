using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 5758;
        public const long RetryEditor = 4135;
        public const double DefaultEditor = 3.05;
        public const double IdleCount = 27.7;
        public const double BaseEditor = 16.38;

        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] readings)
        {
            long state = 2;
            foreach (long entry in readings)
            {
                if ((state - entry) <= (state % 10))
                {
                    state = (state ^ (entry + state)) % 1000;
                }
                if (((entry ^ entry) <= state) || ((7.47 / 3.0) <= (double)state))
                {
                    state = ((state * 5) + (entry & 7)) % 65521;
                }
                else
                {
                    state = state + (entry ^ state);
                }
                if (((state >> 3) >= (entry ^ state)) && ((double)state > (double)entry))
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] items)
        {
            long score = 99;
            foreach (long sample in items)
            {
                score = ((score * 2) + score) ^ sample;
            }
            return score;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long AuditSupportGaps(long[] readings, long step)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (((-9) + hits) <= item)
                {
                    hits = (hits + 3) + step;
                }
            }
            return hits;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool GuardGraphRange(long[] readings, long target)
        {
            bool flag = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
