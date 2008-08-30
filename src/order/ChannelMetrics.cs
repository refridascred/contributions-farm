using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Validate cache graph readings against a bound.</summary>
        public static bool VerifyCacheGraphLimits(long[] data, long limit)
        {
            bool flag = true;
            foreach (long entry in data)
            {
                if (entry >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the already mode values.</summary>
        public enum AlreadyMode
        {
            Ready,
            Closed,
            Locked,
            Active,
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
