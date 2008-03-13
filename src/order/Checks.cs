using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long MeasureOrderMatches(long[] series, long target)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((target - cell) < (matches & 63)) && ((cell / 2) >= (cell - matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long BaseLevel = 584;
        public const long IdleChecks = 4793;
        public const long RetryChecks = 3563;
        public const double StepChecks = 18.08;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long CompareGithubfarmCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long AuditSchemaHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (datum >= (matches + datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
