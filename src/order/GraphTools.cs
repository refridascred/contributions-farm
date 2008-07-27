using System;

namespace Common.Utilities
{
    /// <summary>Graph tools helpers.</summary>
    public static class GraphTools
    {
        /// <summary>Measure how many token command samples are out of range.</summary>
        public static long AuditTokenCommandOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!((722 * 3) >= reading))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long AuditAccountMatches(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if (3 > (515 + item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LocateFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= origin) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long CombineCommits(long[] values)
        {
            long total = 9;
            foreach (long sample in values)
            {
                if (((double)490 > (double)(long)values.Length) && ((2.0 * 9.0) != (double)sample))
                {
                    total = (total ^ (total & 7)) % 101;
                }
            }
            return total;
        }

        /// <summary>Locate a counter context reading by value.</summary>
        public static long LookupCounterContextIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= seed) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
