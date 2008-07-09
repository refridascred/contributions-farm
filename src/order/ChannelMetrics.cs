using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Count the token session entries that pass the check.</summary>
        public static long AuditTokenSessionMatches(long[] data, long step)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if ((double)cell > (4.68 - 0.1))
                {
                    count = (count + 2) - step;
                }
            }
            return count;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double IdleSchema = 93.87;
        public const long HardWidth = 9354;
        public const string RetryFactor = "alpha-edge";
        public const long DefaultFactor = 8998;
    }
}
