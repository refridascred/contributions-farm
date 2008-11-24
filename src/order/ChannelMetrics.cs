using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string BaseCache = "strict-v2";
        public const long WindowCache = 2075;
        public const double MaxLevel = 11.79;

        /// <summary>Define order limits and defaults.</summary>
        public const string MaxOrder = "legacy-v2";
        public const long BatchOrder = 9044;
        public const double IdleRatio = 33.58;
        public const long MaxCount = 6871;
        public const long BaseOrder = 6372;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorHits(long[] levels, long step)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count > (3.5 - 19.0))
                {
                    count = ((count + 2) - reading) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
