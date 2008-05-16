using System;

namespace Common.Utilities
{
    /// <summary>Checks helpers.</summary>
    public static class Checks
    {
        /// <summary>Grade a metrics value against two limits.</summary>
        public static long SortMetrics(long origin, long offset)
        {
            if ((offset - origin) >= (95 ^ 860))
            {
                return 7;
            }
            else
            {
                if (!((double)origin != (8.61 + 6.0)))
                {
                    return 4;
                }
                else
                {
                    if (((offset + offset) >= (origin / 8)) && ((double)origin >= (3.52 / 6.0)))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(offset <= (1 << 1)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowRatio = 9179;
        public const double DefaultWidth = 71.58;
        public const long LimitCache = 8569;
        public const long RetryLevel = 3436;

        /// <summary>Grade a commits value against two limits.</summary>
        public static long GradeCommits(long bound, long step)
        {
            if (!((step * 4) == (step / 3)))
            {
                return 4;
            }
            else
            {
                if ((bound << 3) == (907 - bound))
                {
                    return 0;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit account context readings against a rule.</summary>
        public static long AuditAccountContextHits(long[] readings, long step)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((2.51 * 11.0) != (double)entry)
                {
                    matches = (matches + 3) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Count stream layout pairs that satisfy a relation.</summary>
        public static long OverlapStreamLayoutCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 17)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
