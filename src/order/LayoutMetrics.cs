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

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] items, long floor)
        {
            long anchor = 14;
            foreach (long datum in items)
            {
                anchor = ((((anchor * 4) + (79 - anchor)) % 65521) ^ datum) - floor;
            }
            if (anchor < 76)
            {
                anchor = ((anchor * 3) + ((long)items.Length >> 4)) % 255;
            }
            return anchor;
        }
    }
}
