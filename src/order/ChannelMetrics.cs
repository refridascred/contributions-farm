using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public string Stamp { get; set; } = "";
            public bool Count { get; set; }
            public string Region { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Project the next stream cache value.</summary>
        public static double ProjectStreamCache(double ratio, double offset)
        {
            double ratio2 = offset + ratio;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + offset) + (double)(long)i;
            }
            return ratio2 - (offset - ratio);
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Synced,
            Locked,
            Draft,
            Ready,
        }
    }
}
