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

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (((long)data.Length / 8) > (hits + value))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
