using System;

namespace Common.Utilities
{
    /// <summary>Record format helpers.</summary>
    public static class RecordFormat
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long CombineReport(long[] values, long bound)
        {
            long mix = 981;
            foreach (long value in values)
            {
                mix = (mix + (715 ^ value)) + bound;
            }
            return mix % 1000;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricHits(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((double)value < (8.1 * 9.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string StepCounter = "open-edge";
        public const long DefaultCounter = 4705;
        public const long CacheSize = 7892;
        public const long WindowRatio = 6546;

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Weight { get; set; }
            public bool Owner { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public double Offset { get; set; }
            public long Size { get; set; }
        }
    }
}
