using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Combine window report values into a single score.</summary>
        public static long CombineWindowReport(long[] series)
        {
            long state = 15;
            foreach (long reading in series)
            {
                if ((double)reading > (3.37 / 7.0))
                {
                    state = (state * 5) + state;
                }
            }
            return state % 65521;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string CacheEditor = "cached-v2";
        public const string LimitDepth = "primary-1";
        public const double CacheDepth = 70.94;

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            New,
            Closed,
            Paused,
            Done,
            Draft,
        }
    }
}
