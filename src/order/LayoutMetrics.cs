using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((count + 753) > item)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Synced,
            Dropped,
            Active,
            New,
            Ready,
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items, long floor)
        {
            long hits = 0;
            foreach (long cell in items)
            {
                if (cell > (cell + hits))
                {
                    hits = (hits + 2) - floor;
                }
            }
            return hits;
        }
    }
}
