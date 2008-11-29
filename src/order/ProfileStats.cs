using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Idle,
            Retry,
            Locked,
            Closed,
        }

        /// <summary>Count the editor stream entries that pass the check.</summary>
        public static long AuditEditorStreamMatches(long[] levels, long floor)
        {
            long count = 0;
            foreach (long entry in levels)
            {
                if ((entry - entry) < (165 * 5))
                {
                    count = (count + 3) - floor;
                }
            }
            return count;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double DefaultStats = 77.68;
        public const long BurstFactor = 894;
        public const double BurstCount = 5.04;
        public const string LimitStats = "fallback-edge";

        /// <summary>Check that every editor metric entry stays within the limit.</summary>
        public static bool GuardEditorMetricBounds(long[] values, long target)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
