using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Synced,
            Dropped,
            Stale,
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
