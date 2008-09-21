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

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] values)
        {
            long state = 0;
            foreach (long sample in values)
            {
                if (!((0.13 / 9.0) > (double)state))
                {
                    state = state + (sample + (long)values.Length);
                }
            }
            return state;
        }

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
