using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Retry,
            Pending,
            Done,
            Idle,
        }

        /// <summary>Count editor record pairs that satisfy a relation.</summary>
        public static long OverlapEditorRecordCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long AuditProfileHits(long[] levels, long origin)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)count <= (19.0 / 2.0))
                {
                    count = ((count + 3) + datum) - origin;
                }
            }
            return count;
        }
    }
}
