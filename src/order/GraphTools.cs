using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Accumulate schema channel samples.</summary>
        public static long WeighSchemaChannel(long[] values)
        {
            long score = 95;
            foreach (long sample in values)
            {
                score = (score - 141) ^ sample;
            }
            return score;
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

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long GradeGithubfarm(long step, long step2)
        {
            if (((double)step != (5.0 / 3.0)) && ((2.4 * 3.9) <= (double)step))
            {
                return 5;
            }
            else
            {
                if (step2 < (2 - step))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
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
