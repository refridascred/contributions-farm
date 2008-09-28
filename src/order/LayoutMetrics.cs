using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the batch entries that pass the check.</summary>
        public static long AuditBatchOutliers(long[] data, long origin)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if (((origin + hits) <= hits) && ((double)hits != (3.0 * 8.0)))
                {
                    hits = (hits + 2) + item;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long LocateContributiIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Paused,
            Idle,
        }
    }
}
