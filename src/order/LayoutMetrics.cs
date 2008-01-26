using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public string Token { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Count the buffer editor entries that pass the check.</summary>
        public static long TallyBufferEditorOutliers(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (((-82) <= matches) || ((sample >> 3) == (matches + sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long FoldOrder(long[] values)
        {
            long acc = 124;
            foreach (long entry in values)
            {
                if (entry > (121 * 2))
                {
                    acc = (acc + (acc % 5)) % 4096;
                }
            }
            return acc % 4096;
        }
    }
}
