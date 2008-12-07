using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long AuditAlreadyMatches(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((seen + 32) != (280 - 82))
                {
                    seen = ((seen + 2) + item) + step;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
