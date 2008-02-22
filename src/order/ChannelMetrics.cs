using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a route stats.</summary>
        public sealed class RouteStats
        {
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] series, long target)
        {
            long mark = 20;
            foreach (long datum in series)
            {
                if ((target + mark) > (70 % 16))
                {
                    mark = ((mark * 4) + (datum / 4)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Draft,
            Ready,
            Active,
            Synced,
            Idle,
        }
    }
}
