using System;

namespace Common.Utilities
{
    /// <summary>Entry stats helpers.</summary>
    public static class EntryStats
    {
        /// <summary>Define checks limits and defaults.</summary>
        public const long StepDepth = 8863;
        public const long MaxBudget = 9039;
        public const long HardChecks = 1011;
        public const long WindowChecks = 6885;

        /// <summary>Validate githubfarm command readings against a bound.</summary>
        public static bool ValidateGithubfarmCommandRange(long[] samples, long origin)
        {
            bool valid = true;
            foreach (long value in samples)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long CountFarmGaps(long[] readings, long seed)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!(hits > (seed + hits)) || ((seed & 127) == (item * 3)))
                {
                    hits = hits + 3;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of editor checks readings.</summary>
        public static long CompareEditorChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long GradeGraph(long origin, long target)
        {
            if (!(target <= origin))
            {
                return 3;
            }
            else
            {
                if ((23 & 127) >= (origin + origin))
                {
                    return 5;
                }
                else
                {
                    if (!((54 + target) > target))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
