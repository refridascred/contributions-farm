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

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool VerifyProfileRange(long[] data, long seed)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
