using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Look up the position of a support sample.</summary>
        public static long LocateSupportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] levels)
        {
            long hits = 0;
            foreach (long value in levels)
            {
                if (!!(322 > (value / 9)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool ValidateOrderLimits(long[] items, long target)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the cache class values.</summary>
        public enum CacheClass
        {
            Done,
            Ready,
            Paused,
            Failed,
        }
    }
}
