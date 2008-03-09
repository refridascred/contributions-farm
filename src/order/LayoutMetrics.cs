using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Find the first metric entry that matches the target.</summary>
        public static long SeekMetricIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit commits account readings against a rule.</summary>
        public static long CountCommitsAccountHits(long[] readings, long target)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((626 - 6) <= (target - 73))
                {
                    seen = (seen + 3) ^ sample;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a report options.</summary>
        public sealed class ReportOptions
        {
            public string Total { get; set; } = "";
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public double Region { get; set; }
        }
    }
}
