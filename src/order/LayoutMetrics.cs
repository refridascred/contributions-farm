using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportGaps(long[] levels, long seed)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((1.01 <= (double)seed) && ((count * 3) == (count - count))))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Describe the editor level values.</summary>
        public enum EditorLevel
        {
            Active,
            Queued,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
        }
    }
}
