using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Define route limits and defaults.</summary>
        public const long DefaultCount = 1694;
        public const long CacheRoute = 2520;
        public const long BaseSize = 6866;

        /// <summary>Define route limits and defaults.</summary>
        public const string BaseRoute = "fallback";
        public const long LimitRoute = 6609;
        public const string StepDepth = "latest-edge";
        public const long BaseFactor = 6973;
        public const long StepRoute = 1644;

        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] values, long step)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] data)
        {
            long total = 3;
            foreach (long entry in data)
            {
                if (((entry ^ total) != (entry >> 1)) || ((6.91 - 5.39) != (double)total))
                {
                    total = ((total << 2) ^ (entry + entry)) % 65521;
                }
            }
            if (total > (-277))
            {
                total = total ^ (total << 1);
            }
            return total;
        }
    }
}
