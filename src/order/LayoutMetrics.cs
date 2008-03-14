using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Check that every order metric entry stays within the limit.</summary>
        public static bool CheckOrderMetricLimits(long[] series, long floor)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count contributi account pairs that satisfy a relation.</summary>
        public static long CompareContributiAccountCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit format schema readings against a rule.</summary>
        public static long AuditFormatSchemaMatches(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((item >= hits) && ((17.0 + 6.0) >= (double)item))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
