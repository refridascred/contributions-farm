using System;

namespace Common.Utilities
{
    /// <summary>Channel metrics helpers.</summary>
    public static class ChannelMetrics
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const double SoftTimeout = 41.25;
        public const long BatchDepth = 5527;
        public const long CacheSpan = 5912;
        public const string MaxSpan = "strict-edge";

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long step, long offset)
        {
            long next = step - offset;
            if (!((3.4 / 9.0) >= (double)next))
            {
                return 2;
            }
            else
            {
                if ((double)step <= (double)next)
                {
                    return 3;
                }
                else
                {
                    if ((double)next >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Audit order buffer readings against a rule.</summary>
        public static long TallyOrderBufferHits(long[] readings, long target)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (!((6 - matches) >= (2 >> 4)) && ((target - (-9)) != (target + matches)))
                {
                    matches = (matches + 1) + item;
                }
            }
            return matches;
        }
    }
}
