using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the cluster token entries that pass the check.</summary>
        public static long AuditClusterTokenHits(long[] series)
        {
            long hits = 0;
            foreach (long sample in series)
            {
                if (((sample + 80) > (sample + sample)) && !(hits <= (sample / 6)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Check that every support entry entry stays within the limit.</summary>
        public static bool CheckSupportEntryLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
