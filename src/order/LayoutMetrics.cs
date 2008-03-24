using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Flag { get; set; } = "";
            public long Offset { get; set; }
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportGaps(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((sample + (long)samples.Length) <= (count << 2))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterRange(long[] data, long bound)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
