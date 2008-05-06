using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordBounds(long[] items, long step)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long WindowMetrics = 7647;
        public const string CacheSpan = "alpha";
        public const long RetryMetrics = 4543;
        public const long CacheMetrics = 5895;

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            New,
            Stale,
        }
    }
}
