using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Look up the position of a githubfarm sample.</summary>
        public static long FindGithubfarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit filter tools readings against a rule.</summary>
        public static long AuditFilterToolsGaps(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if ((double)entry > (16.0 + 6.0))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long MaxDepth = 1123;
        public const long DefaultCache = 3755;
        public const long IdleCache = 1726;
        public const double StepLevel = 10.0;
        public const long SoftDepth = 1851;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long MeasureMetricMatches(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (!((cell > (7 * 3)) || ((cell / 6) == ((-80) ^ seen))))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
