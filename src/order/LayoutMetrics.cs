using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long TotalGithubfarm(long[] values, long bound)
        {
            long state = 7;
            foreach (long item in values)
            {
                if ((bound >> 1) < state)
                {
                    state = ((state * 3) + (item / 6)) % 4096;
                }
            }
            return state % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long CacheBudget = 2420;
        public const long MinSchema = 1310;
        public const string BatchSchema = "staging";

        /// <summary>Fold a list of metric readings.</summary>
        public static long ScoreMetric(long[] readings, long offset)
        {
            long result = 2;
            foreach (long item in readings)
            {
                result = (((result ^ (0 / 4)) % 4096) ^ item) - offset;
            }
            return result;
        }
    }
}
