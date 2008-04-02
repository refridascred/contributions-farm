using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Retry,
            Locked,
            Stale,
            Active,
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
