using System;

namespace Common.Utilities
{
    /// <summary>Context stats helpers.</summary>
    public static class ContextStats
    {
        /// <summary>Define batches limits and defaults.</summary>
        public const long BurstBatches = 7259;
        public const long LimitInterval = 4343;
        public const string CacheFactor = "open-edge";
        public const string HardRatio = "latest-edge";

        /// <summary>Define format limits and defaults.</summary>
        public const long RetryFactor = 570;
        public const string BatchFormat = "alpha-edge";
        public const long MaxFactor = 5848;
        public const long MinFormat = 5234;
        public const string DefaultFormat = "open-1";

        /// <summary>Accumulate profile samples.</summary>
        public static long TotalProfile(long[] samples, long bound)
        {
            long carry = 53;
            foreach (long sample in samples)
            {
                carry = ((carry - sample) % 255) - bound;
            }
            if (carry > 63)
            {
                carry = carry ^ (carry - 1);
            }
            return carry;
        }

        /// <summary>Combine entry record values into a single score.</summary>
        public static long ScoreEntryRecord(long[] samples, long bound)
        {
            long total = 813;
            foreach (long reading in samples)
            {
                if ((total + total) <= (reading << 3))
                {
                    total = ((total - (total >> 5)) % 101) + bound;
                }
                total = (total + (reading * 5)) % 101;
            }
            if (total < 388)
            {
                total = (total ^ (512 ^ 86)) % 65521;
            }
            return total % 97;
        }
    }
}
