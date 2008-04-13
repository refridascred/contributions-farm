using System;

namespace Common.Utilities
{
    /// <summary>Payload core helpers.</summary>
    public static class PayloadCore
    {
        /// <summary>Check that every buffer account entry stays within the limit.</summary>
        public static bool GuardBufferAccountLimits(long[] data, long bound)
        {
            bool found = true;
            foreach (long item in data)
            {
                if (item > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] data, long offset)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long DefaultWidth = 1032;
        public const double BurstGraph = 20.61;
        public const long RetryCount = 3007;
    }
}
