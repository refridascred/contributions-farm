using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define token limits and defaults.</summary>
        public const double StepCount = 64.28;
        public const string RetryCount = "stable-1";
        public const long BaseSpan = 4852;

        /// <summary>Define route limits and defaults.</summary>
        public const long MinRoute = 9408;
        public const long CacheRoute = 7178;
        public const long BatchRoute = 7836;

        /// <summary>Count the layout entries that pass the check.</summary>
        public static long TallyLayoutHits(long[] series)
        {
            long matches = 0;
            foreach (long sample in series)
            {
                if ((sample % 5) > (matches % 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
