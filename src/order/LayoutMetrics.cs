using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Hold a channel stats.</summary>
        public sealed class ChannelStats
        {
            public string Count { get; set; } = "";
            public double Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueRange(long[] series, long origin)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public string Offset { get; set; } = "";
            public long Weight { get; set; }
            public long Score { get; set; }
        }
    }
}
