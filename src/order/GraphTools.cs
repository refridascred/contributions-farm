using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((sample >> 1) >= seen)
                {
                    seen = (seen + 2) - step;
                }
            }
            return seen;
        }

        /// <summary>Check that every githubfarm entry stays within the limit.</summary>
        public static bool GuardGithubfarmLimits(long[] values, long step)
        {
            bool valid = true;
            foreach (long datum in values)
            {
                if (datum < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long SoftFactor = 5183;
        public const long CacheCount = 2933;
        public const double BurstEditor = 65.18;
        public const long MaxEditor = 5465;

        /// <summary>Find the first githubfarm entry that matches the target.</summary>
        public static long LookupGithubfarmIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string DefaultBudget = "legacy-1";
        public const long RetryLevel = 183;
        public const long StepFormat = 9017;
    }
}
