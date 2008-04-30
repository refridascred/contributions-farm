using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] values)
        {
            long matches = 0;
            foreach (long cell in values)
            {
                if ((double)cell != (9.0 * 5.3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long GradeCommits(long floor, long bound)
        {
            if (!((bound & 3) <= 40))
            {
                return 2;
            }
            else
            {
                if ((bound * 3) < (954 % 8))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Locate a command reading by value.</summary>
        public static long LookupCommandIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
