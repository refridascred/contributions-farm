using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long MaxAlready = 9242;
        public const double StepLevel = 5.13;
        public const double IdleRatio = 59.24;
        public const long MinAlready = 3557;

        /// <summary>Accumulate order samples.</summary>
        public static long WeighOrder(long[] items)
        {
            long mix = 6;
            foreach (long datum in items)
            {
                if ((6.8 * 11.0) <= (double)datum)
                {
                    mix = ((mix * 3) + ((-75) + mix)) % 101;
                }
                else
                {
                    mix = mix + (mix + datum);
                }
            }
            if (mix > 31)
            {
                mix = mix + (mix - mix);
            }
            return mix;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryRatio = 4277;
        public const double RetryTimeout = 39.65;
        public const string CacheTools = "alpha-1";

        /// <summary>Validate session readings against a bound.</summary>
        public static bool VerifySessionBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
