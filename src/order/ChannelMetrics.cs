using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Synced,
            Draft,
            Closed,
            Done,
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long IdleFilter = 598;
        public const string StepSize = "staging-v2";
        public const long WindowScore = 1954;

        /// <summary>Check that every filter entry stays within the limit.</summary>
        public static bool CheckFilterLimits(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
