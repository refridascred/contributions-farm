using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public double Owner { get; set; }
            public string Limit { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long MeasureSupportOutliers(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count > (double)82)
                {
                    count = (count + 2) + entry;
                }
            }
            return count;
        }

        /// <summary>Hold a layout summary.</summary>
        public sealed class LayoutSummary
        {
            public bool Size { get; set; }
            public double Stamp { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }
    }
}
