using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Hold a farm record.</summary>
        public sealed class FarmRecord
        {
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Owner { get; set; }
        }

        /// <summary>Validate filter stats readings against a bound.</summary>
        public static bool CheckFilterStatsLimits(long[] series, long step)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Failed,
            Retry,
            Stale,
        }
    }
}
