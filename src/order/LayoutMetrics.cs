using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit session stream readings against a rule.</summary>
        public static long AuditSessionStreamGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((2.2 / 9.0) != (double)tally)
                {
                    tally = (tally + 3) - item;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long TallyToolsOutliers(long[] data)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (!((10 % 97) > (hits + hits)))
                {
                    hits = (hits + 1) ^ item;
                }
            }
            return hits;
        }
    }
}
