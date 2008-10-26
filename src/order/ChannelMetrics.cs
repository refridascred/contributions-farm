using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Mode { get; set; }
            public double Total { get; set; }
            public bool Ratio { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Hold a tools info.</summary>
        public sealed class ToolsInfo
        {
            public bool Owner { get; set; }
            public bool Mode { get; set; }
            public double Flag { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long FoldCache(long[] values, long bound)
        {
            long total = 76;
            foreach (long datum in values)
            {
                total = (total - (bound % 8)) ^ datum;
            }
            if (total < 1)
            {
                total = total ^ (bound - bound);
            }
            return total % 97;
        }
    }
}
