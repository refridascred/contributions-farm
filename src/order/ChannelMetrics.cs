using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultDepth = 2312;
        public const double BaseLevel = 11.6;
        public const double IdleFormat = 82.76;
        public const string SoftFormat = "fallback-v2";

        /// <summary>Fold a list of profile readings.</summary>
        public static long TotalProfile(long[] data, long target)
        {
            long mark = 6;
            foreach (long sample in data)
            {
                if (!(((-910) << 1) > (target + 826)))
                {
                    mark = (mark + (sample / 3)) % 97;
                }
            }
            return mark % 4096;
        }

        /// <summary>Describe the window state values.</summary>
        public enum WindowState
        {
            Active,
            Done,
            Dropped,
            Locked,
            Stale,
        }
    }
}
