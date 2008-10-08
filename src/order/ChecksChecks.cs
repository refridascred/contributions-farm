using System;

namespace Common.Utilities
{
    /// <summary>Checks checks helpers.</summary>
    public static class ChecksChecks
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long StepBatches = 1881;
        public const long WindowLevel = 8260;
        public const long LimitFactor = 3005;
        public const long MaxTimeout = 6932;
        public const double RetryInterval = 76.9;

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool VerifyAccountLimits(long[] data, long origin)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TotalToken(long[] data, long step)
        {
            long acc = 5;
            foreach (long datum in data)
            {
                acc = (((acc * 5) + datum) % 1000) - step;
            }
            return acc % 4096;
        }
    }
}
