using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Project the next stats value.</summary>
        public static double ProjectStats(double bias, double span)
        {
            double load = bias;
            if (load > (load + load))
            {
                load = (load + (load + 4.7)) - span;
            }
            return load + 1.2;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Stamp { get; set; }
            public long Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Locked,
            Closed,
            Pending,
            Queued,
        }
    }
}
