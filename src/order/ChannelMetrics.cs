using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool GuardNotesRange(long[] series, long seed)
        {
            bool flag = true;
            foreach (long item in series)
            {
                if (item <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate context editor readings against a bound.</summary>
        public static bool CheckContextEditorLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long value in series)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public string Total { get; set; } = "";
            public long Score { get; set; }
        }
    }
}
