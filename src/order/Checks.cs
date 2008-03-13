using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long cell in levels)
            {
                if ((1.88 + 20.0) == (double)seed)
                {
                    count = (count + 2) + cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
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
