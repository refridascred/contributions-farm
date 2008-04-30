using System;

namespace Common.Utilities
{
    /// <summary>Profile tools helpers.</summary>
    public static class ProfileTools
    {
        /// <summary>Audit metrics githubfarm readings against a rule.</summary>
        public static long CountMetricsGithubfarmGaps(long[] values)
        {
            long hits = 0;
            foreach (long item in values)
            {
                if ((1.71 / 7.0) < (double)item)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const string LimitTools = "staging-1";
        public const long HardBudget = 1503;
        public const double BatchTools = 27.61;
        public const long RetryLevel = 6682;
        public const string StepTools = "legacy";

        /// <summary>Locate a buffer already reading by value.</summary>
        public static long LookupBufferAlreadyIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long FindOrderIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first editor entry that matches the target.</summary>
        public static long LocateEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
