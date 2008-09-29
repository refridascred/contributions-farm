using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Audit editor window readings against a rule.</summary>
        public static long TallyEditorWindowGaps(long[] values, long target)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((double)reading != (3.7 + 2.0))
                {
                    matches = (matches + 1) - target;
                }
            }
            return matches;
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
