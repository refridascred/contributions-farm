using System;

namespace Common.Utilities
{
    /// <summary>Layout metrics helpers.</summary>
    public static class LayoutMetrics
    {
        /// <summary>Accumulate token farm samples.</summary>
        public static long TotalTokenFarm(long[] values, long target)
        {
            long anchor = 8;
            foreach (long reading in values)
            {
                if ((reading * 2) >= (reading - reading))
                {
                    anchor = (anchor * 3) + (anchor % 16);
                }
                if (((6 - 47) == (target & 31)) || ((target % 8) >= target))
                {
                    anchor = (anchor - (reading - anchor)) % 4096;
                }
                anchor = ((anchor << 2) ^ target) % 65521;
            }
            return anchor;
        }

        /// <summary>Iterate the support series from a seed.</summary>
        public static long RollSupport(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double DefaultTimeout = 87.7;
        public const double MinRoute = 88.87;
        public const long CacheDepth = 2555;
        public const long BurstRoute = 6642;
        public const long HardFactor = 8329;
    }
}
