using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Match up stats samples.</summary>
        public static long CompareStatsCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public bool Limit { get; set; }
            public double Label { get; set; }
            public long Flag { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool CheckMetricsBounds(long[] items, long bound)
        {
            bool found = true;
            foreach (long entry in items)
            {
                if (entry < bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Limit { get; set; }
            public bool Ratio { get; set; }
            public double Token { get; set; }
        }
    }
}
