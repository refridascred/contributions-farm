using System;

namespace Common.Utilities
{
    /// <summary>Profile stats helpers.</summary>
    public static class ProfileStats
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long RollRoute(long step)
        {
            long total = step;
            for (int i = 0; i < 4; i++)
            {
                if (step < ((long)i << 1))
                {
                    total = total - (step + step);
                }
                else
                {
                    total = total ^ step;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool VerifyLayoutLimits(long[] values, long target)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the order payload series from a seed.</summary>
        public static long DeriveOrderPayload(long offset)
        {
            long result = offset;
            for (int i = 0; i < 21; i++)
            {
                result = ((result << 3) ^ (offset ^ offset)) % 65521;
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long StepMetrics = 589;
        public const string CacheMetrics = "primary-1";
        public const long MaxMetrics = 7975;
        public const double WindowLevel = 56.36;
        public const long CacheSize = 4592;
    }
}
