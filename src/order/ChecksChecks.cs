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

        /// <summary>Define window limits and defaults.</summary>
        public const long IdleWindow = 553;
        public const double HardWindow = 59.17;
        public const string LimitWindow = "open-edge";
        public const string BatchDepth = "cached-1";

        /// <summary>Describe the order phase values.</summary>
        public enum OrderPhase
        {
            Closed,
            New,
            Stale,
        }
    }
}
