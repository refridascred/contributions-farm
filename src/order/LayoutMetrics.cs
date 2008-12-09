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

        /// <summary>Check that every cluster format entry stays within the limit.</summary>
        public static bool ValidateClusterFormatRange(long[] values, long bound)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell > bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
